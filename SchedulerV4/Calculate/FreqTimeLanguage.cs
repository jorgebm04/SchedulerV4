using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class FreqTimeLanguage
    {
        public static string SetHoursInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "horas";
                    break;
                case (int)LanguageEnum.Language.EnglishGB:
                    result = "hours";
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    result = "hours";
                    break;
            }
            return result;
        }

        public static string SetMinutesInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "minutos";
                    break;
                case (int)LanguageEnum.Language.EnglishGB:
                    result = "minutes";
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    result = "minutes";
                    break;
            }
            return result;
        }

        public static string SetSecondsInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "segundos";
                    break;
                case (int)LanguageEnum.Language.EnglishGB:
                    result = "seconds";
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    result = "seconds";
                    break;
            }
            return result;
        }
    }
}
