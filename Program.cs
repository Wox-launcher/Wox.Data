using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Wox.Data
{
    public class Program
    {
        const string DLLsDirectory = "DLLs";
        const string TargetDLLsDirectory = "TargetDLLs";

        public void AnalysisTargetModule(string module)
        {
            var targetModule = ModuleDefinition.ReadModule(module);
            var targetTypes = targetModule.Types.Where(t => t.IsPublic).ToList();
            var targetMethods = targetTypes.SelectMany(t => t.Methods).Where(m => m.IsPublic).ToList();
            var targetInterface = targetTypes.Where(t => t.IsInterface && t.IsPublic).ToList();

            var modules = Modules();
            var types = modules.SelectMany(m => m.Types).ToList();
            var instructions = Instructions(types);

            var modulesUsingTargetReference = modules.Where(m => m.AssemblyReferences.
                                                                   Select(r => r.Name).
                                                                   Contains(targetModule.Assembly.Name.Name));
            var usedTypes = UsedTypes(instructions, targetTypes);
            var usedMethods = UsedMethods(instructions, targetMethods);
            var usedInterfaces = UsedInterfaces(types, targetInterface);
            var tableForMethods = Table(usedMethods);
            var tableForInterfaces = Table(usedInterfaces);
            var tableFroTypes = Table(usedTypes);
        }

        private string Table(Dictionary<MethodDefinition, List<MethodReference>> dict)
        {
            string table = "";
            if (dict == null || dict.Count == 0) return table;
            var data = (from d in dict
                        select new
                        {
                            Type = d.Key.DeclaringType.FullName,
                            Member = d.Key.Name,
                            Count = d.Value.Distinct(new ModuleEqualityComparer<MethodReference>()).Count()
                        }).ToList();
            int firstColumnWidth = data.Max(d => d.Type.Length);
            int secondColumnWidth = data.Max(d => d.Member.Length);
            // 5 is the length of "Count"
            int thirdColumnWidth = 5;
            // + 2 is used for code block seperator: ` `
            string head = $"| Type{new string(' ', firstColumnWidth - 4 + 2)} " +
                          $"| Member{new string(' ', secondColumnWidth - 6 + 2)} " +
                          $"| Count " +
                          $"|{Environment.NewLine}" +
                          $"| {new string('-', firstColumnWidth + 2)} " +
                          $"| {new string('-', secondColumnWidth + 2)} " +
                          $"| {new string('-', thirdColumnWidth)} " +
                          $"|{Environment.NewLine}";
            table = table + head;
            foreach (var d in data.OrderBy(k => k.Type))
            {
                string firstColumnComplement = new string(' ', firstColumnWidth - d.Type.Length);
                string secondColumnComplement = new string(' ', secondColumnWidth - d.Member.Length);
                string thirdColumnComplement = new string(' ', thirdColumnWidth - d.Count.ToString().Length);
                string line = $"| `{d.Type}`{firstColumnComplement} " +
                              $"| `{d.Member}`{secondColumnComplement} " +
                              $"| {d.Count}{thirdColumnComplement} " +
                              $"|{Environment.NewLine}";
                table = table + line;
            }
            return table;
        }

        private string Table<T>(Dictionary<TypeDefinition, List<T>> dict) where T : MemberReference
        {
            string table = "";
            if (dict == null || dict.Count == 0) return table;
            var data = (from d in dict
                        select new
                        {
                            Type = d.Key.FullName,
                            Count = d.Value.Distinct(new ModuleEqualityComparer<T>()).Count()
                        }).ToList();
            int firstColumnWidth = data.Max(d => d.Type.Length);
            // 5 is the length of "Count"
            int thirdColumnWidth = 5;
            // + 2 is used for code block seperator: ` `
            string head = $"| Type{new string(' ', firstColumnWidth - 4 + 2)} " +
                          $"| Count " +
                          $"|{Environment.NewLine}" +
                          $"| {new string('-', firstColumnWidth + 2)} " +
                          $"| {new string('-', thirdColumnWidth)} " +
                          $"|{Environment.NewLine}";
            table = table + head;
            foreach (var d in data.OrderBy(k => k.Type))
            {
                string firstColumnComplement = new string(' ', firstColumnWidth - d.Type.Length);
                string thirdColumnComplement = new string(' ', thirdColumnWidth - d.Count.ToString().Length);
                string line = $"| `{d.Type}`{firstColumnComplement} " +
                              $"| {d.Count}{thirdColumnComplement} " +
                              $"|{Environment.NewLine}";
                table = table + line;
            }
            return table;
        }

        private Dictionary<TypeDefinition, List<TypeReference>> UsedInterfaces
            (IList<TypeDefinition> types, IList<TypeDefinition> definitions)
        {
            var references = types.SelectMany(t => t.Interfaces);
            var result = from r in references
                       let def = definitions.FirstOrDefault(d => d.FullName == r.FullName)
                       where def != null
                       group r by def;
            return result.ToDictionary(g => g.Key, g => g.ToList());
        }

        private Dictionary<MethodDefinition, List<MethodReference>> UsedMethods
            (IList<Instruction> instructions, IList<MethodDefinition> definitions)
        {
            var references = instructions.Select(i => i.Operand as MethodReference).Where(o => o != null).ToList();
            var result = from r in references
                         let type = (r.DeclaringType as GenericInstanceType)?.ElementType ?? r.DeclaringType
                         let def = definitions.FirstOrDefault(d => d.DeclaringType.FullName == type.FullName && d.Name == r.Name)
                         where def != null
                         group r by def;
            return result.ToDictionary(g => g.Key, g => g.ToList());
        }

        private Dictionary<TypeDefinition, List<MethodReference>> UsedTypes
            (IList<Instruction> instructions, IList<TypeDefinition> definitions)
        {
            var references = instructions.Select(i => i.Operand as MethodReference).Where(o => o != null).ToList();
            var result = from r in references
                         let type = (r.DeclaringType as GenericInstanceType)?.ElementType ?? r.DeclaringType
                         let def = definitions.FirstOrDefault(d => d.FullName == type.FullName)
                         where def != null
                         group r by def;
            return result.ToDictionary(g => g.Key, g => g.ToList());
        }
        private List<Instruction> Instructions(IEnumerable<TypeDefinition> types)
        {
            var instructions = types.SelectMany(t => t.Methods).Where(m => m.Body != null).
                                     SelectMany(m => m.Body.Instructions);
            return instructions.ToList();
        }

        private List<ModuleDefinition> Modules()
        {
            var dlls = Directory.GetFiles(DLLsDirectory);
            var types = dlls.Select(ModuleDefinition.ReadModule);
            return types.ToList();
        }

        public static void Main(string[] args)
        {
            var p = new Program();
            p.AnalysisTargetModule(Path.Combine(TargetDLLsDirectory, "Wox.Plugin.dll"));
            p.AnalysisTargetModule(Path.Combine(TargetDLLsDirectory, "Wox.Infrastructure.dll"));
        }
    }

    public class ModuleEqualityComparer<T> : EqualityComparer<T> where T : MemberReference
    {
        public override bool Equals(T x, T y)
        {
            var equality = x.Module.Name == y.Module.Name;
            return equality;
        }

        public override int GetHashCode(T obj)
        {
            var hashCode = obj.Module.Name.GetHashCode();
            return hashCode;
        }
    }
}
