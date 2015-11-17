# Wox.Data
Collect data for Wox plugins and do dome statistics

# Unused Methods

| Type                                           | Member                           |
| ---------------------------------------------- | -------------------------------- |
| `Wox.Plugin.ActionContext`                     | `.ctor`                          |
| `Wox.Plugin.ActionContext`                     | `get_SpecialKeyState`            |
| `Wox.Plugin.ActionContext`                     | `set_SpecialKeyState`            |
| `Wox.Plugin.ActionKeywordsChangedEventArgs`    | `.ctor`                          |
| `Wox.Plugin.ActionKeywordsChangedEventArgs`    | `get_NewActionKeyword`           |
| `Wox.Plugin.ActionKeywordsChangedEventArgs`    | `get_OldActionKeyword`           |
| `Wox.Plugin.ActionKeywordsChangedEventArgs`    | `set_NewActionKeyword`           |
| `Wox.Plugin.ActionKeywordsChangedEventArgs`    | `set_OldActionKeyword`           |
| `Wox.Plugin.ActionKeywordsChangedEventHandler` | `.ctor`                          |
| `Wox.Plugin.ActionKeywordsChangedEventHandler` | `BeginInvoke`                    |
| `Wox.Plugin.ActionKeywordsChangedEventHandler` | `EndInvoke`                      |
| `Wox.Plugin.ActionKeywordsChangedEventHandler` | `Invoke`                         |
| `Wox.Plugin.AfterWoxQueryEventHandler`         | `.ctor`                          |
| `Wox.Plugin.AfterWoxQueryEventHandler`         | `BeginInvoke`                    |
| `Wox.Plugin.AfterWoxQueryEventHandler`         | `EndInvoke`                      |
| `Wox.Plugin.AfterWoxQueryEventHandler`         | `Invoke`                         |
| `Wox.Plugin.AllowedLanguage`                   | `get_CSharp`                     |
| `Wox.Plugin.AllowedLanguage`                   | `get_Executable`                 |
| `Wox.Plugin.AllowedLanguage`                   | `get_Python`                     |
| `Wox.Plugin.AllowedLanguage`                   | `IsAllowed`                      |
| `Wox.Plugin.IContextMenu`                      | `LoadContextMenus`               |
| `Wox.Plugin.IExclusiveQuery`                   | `IsExclusiveQuery`               |
| `Wox.Plugin.IHttpProxy`                        | `get_Enabled`                    |
| `Wox.Plugin.IHttpProxy`                        | `get_Password`                   |
| `Wox.Plugin.IHttpProxy`                        | `get_Port`                       |
| `Wox.Plugin.IHttpProxy`                        | `get_Server`                     |
| `Wox.Plugin.IHttpProxy`                        | `get_UserName`                   |
| `Wox.Plugin.IInstantQuery`                     | `IsInstantQuery`                 |
| `Wox.Plugin.IMultipleActionKeywords`           | `add_ActionKeywordsChanged`      |
| `Wox.Plugin.IMultipleActionKeywords`           | `remove_ActionKeywordsChanged`   |
| `Wox.Plugin.IPlugin`                           | `Init`                           |
| `Wox.Plugin.IPlugin`                           | `Query`                          |
| `Wox.Plugin.IPluginI18n`                       | `GetLanguagesFolder`             |
| `Wox.Plugin.IPluginI18n`                       | `GetTranslatedPluginDescription` |
| `Wox.Plugin.IPluginI18n`                       | `GetTranslatedPluginTitle`       |
| `Wox.Plugin.IPublicAPI`                        | `add_BackKeyDownEvent`           |
| `Wox.Plugin.IPublicAPI`                        | `add_ResultItemDropEvent`        |
| `Wox.Plugin.IPublicAPI`                        | `ChangeQueryText`                |
| `Wox.Plugin.IPublicAPI`                        | `CloseApp`                       |
| `Wox.Plugin.IPublicAPI`                        | `GetAllPlugins`                  |
| `Wox.Plugin.IPublicAPI`                        | `InstallPlugin`                  |
| `Wox.Plugin.IPublicAPI`                        | `OpenSettingDialog`              |
| `Wox.Plugin.IPublicAPI`                        | `remove_BackKeyDownEvent`        |
| `Wox.Plugin.IPublicAPI`                        | `remove_GlobalKeyboardEvent`     |
| `Wox.Plugin.IPublicAPI`                        | `remove_ResultItemDropEvent`     |
| `Wox.Plugin.IPublicAPI`                        | `ShellRun`                       |
| `Wox.Plugin.IPublicAPI`                        | `ShowContextMenu`                |
| `Wox.Plugin.ISettingProvider`                  | `CreateSettingPanel`             |
| `Wox.Plugin.PluginInitContext`                 | `.ctor`                          |
| `Wox.Plugin.PluginInitContext`                 | `get_Proxy`                      |
| `Wox.Plugin.PluginInitContext`                 | `set_API`                        |
| `Wox.Plugin.PluginInitContext`                 | `set_Proxy`                      |
| `Wox.Plugin.PluginMetadata`                    | `.ctor`                          |
| `Wox.Plugin.PluginMetadata`                    | `get_ActionKeywords`             |
| `Wox.Plugin.PluginMetadata`                    | `get_Author`                     |
| `Wox.Plugin.PluginMetadata`                    | `get_Description`                |
| `Wox.Plugin.PluginMetadata`                    | `get_ExecuteFileName`            |
| `Wox.Plugin.PluginMetadata`                    | `get_ExecuteFilePath`            |
| `Wox.Plugin.PluginMetadata`                    | `get_IcoPath`                    |
| `Wox.Plugin.PluginMetadata`                    | `get_ID`                         |
| `Wox.Plugin.PluginMetadata`                    | `get_Language`                   |
| `Wox.Plugin.PluginMetadata`                    | `get_Name`                       |
| `Wox.Plugin.PluginMetadata`                    | `get_Version`                    |
| `Wox.Plugin.PluginMetadata`                    | `get_Website`                    |
| `Wox.Plugin.PluginMetadata`                    | `set_ActionKeyword`              |
| `Wox.Plugin.PluginMetadata`                    | `set_ActionKeywords`             |
| `Wox.Plugin.PluginMetadata`                    | `set_Author`                     |
| `Wox.Plugin.PluginMetadata`                    | `set_Description`                |
| `Wox.Plugin.PluginMetadata`                    | `set_ExecuteFileName`            |
| `Wox.Plugin.PluginMetadata`                    | `set_IcoPath`                    |
| `Wox.Plugin.PluginMetadata`                    | `set_ID`                         |
| `Wox.Plugin.PluginMetadata`                    | `set_Language`                   |
| `Wox.Plugin.PluginMetadata`                    | `set_Name`                       |
| `Wox.Plugin.PluginMetadata`                    | `set_PluginDirectory`            |
| `Wox.Plugin.PluginMetadata`                    | `set_Version`                    |
| `Wox.Plugin.PluginMetadata`                    | `set_Website`                    |
| `Wox.Plugin.PluginMetadata`                    | `ToString`                       |
| `Wox.Plugin.PluginPair`                        | `.ctor`                          |
| `Wox.Plugin.PluginPair`                        | `Equals`                         |
| `Wox.Plugin.PluginPair`                        | `get_Metadata`                   |
| `Wox.Plugin.PluginPair`                        | `get_Plugin`                     |
| `Wox.Plugin.PluginPair`                        | `GetHashCode`                    |
| `Wox.Plugin.PluginPair`                        | `ToString`                       |
| `Wox.Plugin.Query`                             | `.ctor`                          |
| `Wox.Plugin.Query`                             | `get_ActionKeyword`              |
| `Wox.Plugin.Query`                             | `get_ActionName`                 |
| `Wox.Plugin.Query`                             | `get_SecondSearch`               |
| `Wox.Plugin.Query`                             | `get_SecondToEndSearch`          |
| `Wox.Plugin.Query`                             | `get_Terms`                      |
| `Wox.Plugin.Query`                             | `get_ThirdSearch`                |
| `Wox.Plugin.Query`                             | `set_ActionKeyword`              |
| `Wox.Plugin.Query`                             | `set_Terms`                      |
| `Wox.Plugin.Query`                             | `ToString`                       |
| `Wox.Plugin.Result`                            | `.ctor`                          |
| `Wox.Plugin.Result`                            | `Equals`                         |
| `Wox.Plugin.Result`                            | `get_Action`                     |
| `Wox.Plugin.Result`                            | `get_ContextMenu`                |
| `Wox.Plugin.Result`                            | `get_FullIcoPath`                |
| `Wox.Plugin.Result`                            | `get_IcoPath`                    |
| `Wox.Plugin.Result`                            | `get_PluginDirectory`            |
| `Wox.Plugin.Result`                            | `get_PluginID`                   |
| `Wox.Plugin.Result`                            | `get_Score`                      |
| `Wox.Plugin.Result`                            | `get_SubTitle`                   |
| `Wox.Plugin.Result`                            | `GetHashCode`                    |
| `Wox.Plugin.Result`                            | `set_PluginID`                   |
| `Wox.Plugin.Result`                            | `ToString`                       |
| `Wox.Plugin.ResultItemDropEventHandler`        | `.ctor`                          |
| `Wox.Plugin.ResultItemDropEventHandler`        | `BeginInvoke`                    |
| `Wox.Plugin.ResultItemDropEventHandler`        | `EndInvoke`                      |
| `Wox.Plugin.ResultItemDropEventHandler`        | `Invoke`                         |
| `Wox.Plugin.SpecialKeyState`                   | `.ctor`                          |
| `Wox.Plugin.SpecialKeyState`                   | `get_CtrlPressed`                |
| `Wox.Plugin.SpecialKeyState`                   | `get_ShiftPressed`               |
| `Wox.Plugin.SpecialKeyState`                   | `get_WinPressed`                 |
| `Wox.Plugin.SpecialKeyState`                   | `set_AltPressed`                 |
| `Wox.Plugin.SpecialKeyState`                   | `set_CtrlPressed`                |
| `Wox.Plugin.SpecialKeyState`                   | `set_ShiftPressed`               |
| `Wox.Plugin.SpecialKeyState`                   | `set_WinPressed`                 |
| `Wox.Plugin.WoxGlobalKeyboardEventHandler`     | `BeginInvoke`                    |
| `Wox.Plugin.WoxGlobalKeyboardEventHandler`     | `EndInvoke`                      |
| `Wox.Plugin.WoxGlobalKeyboardEventHandler`     | `Invoke`                         |
| `Wox.Plugin.WoxKeyDownEventArgs`               | `.ctor`                          |
| `Wox.Plugin.WoxKeyDownEventArgs`               | `get_keyEventArgs`               |
| `Wox.Plugin.WoxKeyDownEventArgs`               | `get_Query`                      |
| `Wox.Plugin.WoxKeyDownEventArgs`               | `set_keyEventArgs`               |
| `Wox.Plugin.WoxKeyDownEventArgs`               | `set_Query`                      |
| `Wox.Plugin.WoxKeyDownEventHandler`            | `.ctor`                          |
| `Wox.Plugin.WoxKeyDownEventHandler`            | `BeginInvoke`                    |
| `Wox.Plugin.WoxKeyDownEventHandler`            | `EndInvoke`                      |
| `Wox.Plugin.WoxKeyDownEventHandler`            | `Invoke`                         |
| `Wox.Plugin.WoxQueryEventArgs`                 | `.ctor`                          |
| `Wox.Plugin.WoxQueryEventArgs`                 | `get_Query`                      |
| `Wox.Plugin.WoxQueryEventArgs`                 | `set_Query`                      |


# Unused Fields

| Type               | Member                     |
| ------------------ | -------------------------- |
| `Wox.Plugin.Query` | `ActionKeywordSeperater`   |
| `Wox.Plugin.Query` | `GlobalPluginWildcardSign` |
| `Wox.Plugin.Query` | `TermSeperater`            |


# Unused Interfaces

| Type |
| ---- |
|`Wox.Plugin.IFeatures`|
|`Wox.Plugin.IContextMenu`|
|`Wox.Plugin.IExclusiveQuery`|
|`Wox.Plugin.IInstantQuery`|
|`Wox.Plugin.IMultipleActionKeywords`|
|`Wox.Plugin.IHttpProxy`|
|`Wox.Plugin.IPublicAPI`|
|`Wox.Plugin.Features.IExclusiveQuery`|
