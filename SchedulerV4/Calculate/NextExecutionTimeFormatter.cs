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
                    settings.NextExecutionTime = date.ToString("dd/MM/yyyy HH:mm");
                    break;
                case (int)LanguageEnum.Language.EnglishUK:
                    settings.NextExecutionTime = date.ToString("dd/MM/yyyy HH:mm");
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.NextExecutionTime = date.ToString("MM/dd/yyyy HH:mm");
                    break;
            }
            #pragma warning disable CS8603 // Possible null reference return.
            return settings.NextExecutionTime;
            #pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
