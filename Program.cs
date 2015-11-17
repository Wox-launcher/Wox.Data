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
            var woxPlugin = ModuleDefinition.ReadModule(module);
            var targetTypes = woxPlugin.Types.Where(t => t.IsPublic).ToList();
            var targetMethods = targetTypes.SelectMany(t => t.Methods).Where(m => m.IsPublic);
            var targetFields = targetTypes.SelectMany(t => t.Fields).Where(f => f.IsPublic);
            var targetInterface = targetTypes.Where(t => t.IsInterface && t.IsPublic);

            var types = Types();
            var instructions = Instructions(types);
            var unusedMethods = UnusedMember<MethodReference>(instructions, targetMethods);
            var unusedFields = UnusedMember<FieldReference>(instructions, targetFields);
            var unusedInterfaces = UnusedInterfaces(types, targetInterface);
            var table = TableFromDictionary(unusedMethods);
            table = table + TableFromDictionary(unusedFields);
        }

        private string TableFromDictionary(Dictionary<TypeReference, List<MemberReference>> dict)
        {
            string table = "";
            int firstColumnWidth = dict.Keys.Max(k => k.FullName.Length);
            int secondColumnWidth = dict.Values.SelectMany(v => v).Max(k => k.Name.Length);
            string head = $"| Type{new string(' ', firstColumnWidth - 4)} | Member{new string(' ', secondColumnWidth - 6)} |{Environment.NewLine}" +
                          $"| {new string('-', firstColumnWidth)} | {new string('-', secondColumnWidth)} |{Environment.NewLine}";
            table = table + head;
            foreach (var type in dict.Keys.OrderBy(k => k.FullName))
            {
                foreach (var member in dict[type].OrderBy(m => m.Name))
                {
                    string firstColumnComplement = new string(' ', firstColumnWidth - type.FullName.Length);
                    string secondColumnComplement = new string(' ', secondColumnWidth - member.Name.Length);
                    string line = $"| {type.FullName}{firstColumnComplement} " +
                                  $"| {member.Name}{secondColumnComplement} |{Environment.NewLine}";
                    table = table + line;
                }
            }
            return table;
        }

        private List<TypeReference> UnusedInterfaces(IEnumerable<TypeDefinition> types, IEnumerable<TypeDefinition> targetInterface)
        {
            var interfaces = types.SelectMany(t => t.Interfaces);
            var unused = targetInterface.Except(interfaces, new MemberReferenceEqualityComparer()).
                                         Select(m => m as TypeReference).Where(t => t != null);
            return unused.ToList();
        }


        private Dictionary<TypeReference, List<MemberReference>> UnusedMember<T>(IEnumerable<Instruction> instructions, IEnumerable<MemberReference> targetMembers) where T : MemberReference
        {
            var memberReferences = instructions.Select(i => i.Operand as T).Where(o => o != null);
            var unusedMember = targetMembers.Except(memberReferences, new MemberReferenceEqualityComparer()).
                                      GroupBy(m => m.DeclaringType).ToDictionary(g => g.Key, g => g.ToList());
            return unusedMember;
        }

        private List<Instruction> Instructions(IEnumerable<TypeDefinition> types)
        {
            var instructions = types.SelectMany(t => t.Methods).Where(m => m.Body != null).
                                     SelectMany(m => m.Body.Instructions);
            return instructions.ToList();
        }

        private List<TypeDefinition> Types()
        {
            var dlls = Directory.GetFiles(DLLsDirectory);
            var types = dlls.Select(ModuleDefinition.ReadModule).SelectMany(m => m.Types);
            return types.ToList();
        }

        public static void Main(string[] args)
        {
            var p = new Program();
            p.AnalysisTargetModule($@"{TargetDLLsDirectory}\Wox.Plugin.dll");
        }
    }

    public class MemberReferenceEqualityComparer : IEqualityComparer<MemberReference>
    {
        public bool Equals(MemberReference x, MemberReference y)
        {
            return x.FullName == y.FullName;
        }

        public int GetHashCode(MemberReference obj)
        {
            return obj.FullName.GetHashCode();
        }
    }
}
