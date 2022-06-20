using SchedulerV4.Enums;
using System.Globalization;

namespace SchedulerV4.Calculate
{
    public static class NextExecutionTimeFormatter
    {
        public static string SetNextExeccutionTimeFormat(Settings settings, DateTime date)
        {
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    settings.NextExecutionTime = date.ToString("g", CultureInfo.GetCultureInfo("es-ES"));
                    break;
                case (int)LanguageEnum.Language.EnglishUK:
                    settings.NextExecutionTime = date.ToString("g", CultureInfo.GetCultureInfo("en-UK"));
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.NextExecutionTime = date.ToString("g", CultureInfo.GetCultureInfo("en-US"));
                    break;
            }
            #pragma warning disable CS8603 // Possible null reference return.
            return settings.NextExecutionTime;
            #pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
