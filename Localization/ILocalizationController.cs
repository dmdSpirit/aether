#nullable enable
using System.Collections.Generic;
using UniRx;
using UnityEngine.Localization;

namespace aether.Aether.Localization
{
    public interface ILocalizationController
    {
        Language? SelectedLanguage { get; }
        IReadOnlyList<Language> AvailableLanguages { get; }
        IReadOnlyReactiveProperty<bool> IsInitialized { get; }
        void SelectLanguage(Language language);
        LocalizedString GetLocalizedString(string table, string entryID);
    }
}