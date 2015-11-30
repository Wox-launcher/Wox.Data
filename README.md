# Wox.Data
Collect data for Wox plugins and do dome statistics

# Used member analysis for `Wox.Plugin` (C#)
## Used Methods

| Type                                       | Member                      | Count |
| ------------------------------------------ | --------------------------- | ----- |
| `Wox.Plugin.IPublicAPI`                    | `ShowMsg`                   | 2     |
| `Wox.Plugin.IPublicAPI`                    | `ShowApp`                   | 3     |
| `Wox.Plugin.IPublicAPI`                    | `ChangeQuery`               | 4     |
| `Wox.Plugin.IPublicAPI`                    | `HideApp`                   | 2     |
| `Wox.Plugin.IPublicAPI`                    | `ReloadPlugins`             | 1     |
| `Wox.Plugin.IPublicAPI`                    | `add_GlobalKeyboardEvent`   | 1     |
| `Wox.Plugin.IPublicAPI`                    | `GetTranslation`            | 1     |
| `Wox.Plugin.IPublicAPI`                    | `StartLoadingBar`           | 1     |
| `Wox.Plugin.IPublicAPI`                    | `StopLoadingBar`            | 1     |
| `Wox.Plugin.IPublicAPI`                    | `PushResults`               | 1     |
| `Wox.Plugin.PluginInitContext`             | `get_CurrentPluginMetadata` | 11    |
| `Wox.Plugin.PluginInitContext`             | `get_API`                   | 8     |
| `Wox.Plugin.PluginMetadata`                | `get_PluginDirectory`       | 9     |
| `Wox.Plugin.PluginMetadata`                | `get_ActionKeyword`         | 2     |
| `Wox.Plugin.PluginMetadata`                | `get_FullIcoPath`           | 1     |
| `Wox.Plugin.Query`                         | `get_Search`                | 4     |
| `Wox.Plugin.Query`                         | `GetAllRemainingParameter`  | 9     |
| `Wox.Plugin.Query`                         | `get_ActionParameters`      | 14    |
| `Wox.Plugin.Query`                         | `get_RawQuery`              | 2     |
| `Wox.Plugin.Query`                         | `get_FirstSearch`           | 2     |
| `Wox.Plugin.Query`                         | `.ctor`                     | 2     |
| `Wox.Plugin.Result`                        | `.ctor`                     | 28    |
| `Wox.Plugin.Result`                        | `set_Title`                 | 28    |
| `Wox.Plugin.Result`                        | `set_SubTitle`              | 25    |
| `Wox.Plugin.Result`                        | `set_IcoPath`               | 28    |
| `Wox.Plugin.Result`                        | `set_Action`                | 27    |
| `Wox.Plugin.Result`                        | `get_Title`                 | 1     |
| `Wox.Plugin.Result`                        | `set_Score`                 | 3     |
| `Wox.Plugin.Result`                        | `set_ContextMenu`           | 2     |
| `Wox.Plugin.Result`                        | `get_ContextData`           | 1     |
| `Wox.Plugin.Result`                        | `set_ContextData`           | 1     |
| `Wox.Plugin.SpecialKeyState`               | `get_AltPressed`            | 1     |
| `Wox.Plugin.WoxGlobalKeyboardEventHandler` | `.ctor`                     | 1     |

## Used Interfaces

| Type                                | Count |
| ----------------------------------- | ----- |
| `Wox.Plugin.Features.IContextMenu`  | 1     |
| `Wox.Plugin.Features.IInstantQuery` | 1     |
| `Wox.Plugin.IPlugin`                | 29    |
| `Wox.Plugin.IPluginI18n`            | 1     |
| `Wox.Plugin.ISettingProvider`       | 5     |

## Used Types

| Type                                       | Count |
| ------------------------------------------ | ----- |
| `Wox.Plugin.IPublicAPI`                    | 8     |
| `Wox.Plugin.PluginInitContext`             | 14    |
| `Wox.Plugin.PluginMetadata`                | 11    |
| `Wox.Plugin.Query`                         | 25    |
| `Wox.Plugin.Result`                        | 28    |
| `Wox.Plugin.SpecialKeyState`               | 1     |
| `Wox.Plugin.WoxGlobalKeyboardEventHandler` | 1     |

# Used member analysis for `Wox.Infrastructure` (C#)
## Used Methods

| Type                                       | Member         | Count |
| ------------------------------------------ | -------------- | ----- |
| `Wox.Infrastructure.FuzzyMatcher`          | `Create`       | 2     |
| `Wox.Infrastructure.FuzzyMatcher`          | `Evaluate`     | 1     |
| `Wox.Infrastructure.MatchResult`           | `get_Score`    | 1     |
| `Wox.Infrastructure.Storage.BaseStorage`1` | `Save`         | 4     |
| `Wox.Infrastructure.Storage.BaseStorage`1` | `get_Instance` | 5     |
| `Wox.Infrastructure.Unidecoder`            | `Unidecode`    | 1     |

## Used Types
| Type                                        | Count |
| ------------------------------------------- | ----- |
| `Wox.Infrastructure.FuzzyMatcher`           | 2     |
| `Wox.Infrastructure.MatchResult`            | 1     |
| `Wox.Infrastructure.Storage.BaseStorage`1`  | 5     |
| `Wox.Infrastructure.Storage.JsonStrorage`1` | 5     |
| `Wox.Infrastructure.Unidecoder`             | 1     |

