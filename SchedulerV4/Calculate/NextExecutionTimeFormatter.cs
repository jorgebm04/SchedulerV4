using SchedulerV4.Enums;
using System.Globalization;

namespace SchedulerV4.Calculate
{
    public static class NextExecutionTimeFormatter
    {
        public static string SetNextExecutionTimeFormat(Settings settings, DateTime date)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    culture = new CultureInfo("es-ES",true);
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    culture = new CultureInfo("en-GB", true);
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    culture = new CultureInfo("en-US", true);
                    break;
            }
            return settings.NextExecutionTime = date.ToString("g", culture);
        }
    }
}
