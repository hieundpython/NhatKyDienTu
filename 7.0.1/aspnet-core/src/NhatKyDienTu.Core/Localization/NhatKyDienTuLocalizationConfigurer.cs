using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NhatKyDienTu.Localization
{
    public static class NhatKyDienTuLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NhatKyDienTuConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NhatKyDienTuLocalizationConfigurer).GetAssembly(),
                        "NhatKyDienTu.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
