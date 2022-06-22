using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class DayLanguage
    {
        public static string SetMondayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "lunes";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "monday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "monday";
                    break;
            }
            return result;
        }

        public static string SetTuesdayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "martes";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "tuesday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "tuesday";
                    break;
            }
            return result;
        }

        public static string SetWednesdayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "miercoles";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "wednesday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "wednesday";
                    break;
            }
            return result;
        }

        public static string SetThursdayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "jueves";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "thursday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "thursday";
                    break;
            }
            return result;
        }

        public static string SetFridayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "viernes";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "friday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "friday";
                    break;
            }
            return result;
        }

        public static string SetSaturdayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "sabado";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "saturday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "saturday";
                    break;
            }
            return result;
        }

        public static string SetSundayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "domingo";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "sunday";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "sunday";
                    break;
            }
            return result;
        }

        public static string SetDayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "dia";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "day";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "day";
                    break;
            }
            return result;
        }

        public static string SetWeekDayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "dia de la semana";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "week day";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "week day";
                    break;
            }
            return result;
        }

        public static string SetWeekEndDayInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "dia de fin de semana";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "weekend day";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "weekend day";
                    break;
            }
            return result;
        }
    }
}
