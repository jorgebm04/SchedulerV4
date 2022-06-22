using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class FreqLanguage
    {
        public static string SetFreqFirstInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "primer";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "first";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "first";
                    break;
            }
            return result;
        }

        public static string SetFreqSecondInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "segundo";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "second";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "second";
                    break;
            }
            return result;
        }

        public static string SetFreqThirdInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "tercer";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "third";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "third";
                    break;
            }
            return result;
        }

        public static string SetFreqFourthInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "cuarto";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "fourth";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "fourth";
                    break;
            }
            return result;
        }

        public static string SetFreqLastInLanguage(Settings settings)
        {
            string result = "";
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    result = "último";
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    result = "last";
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    result = "last";
                    break;
            }
            return result;
        }
    }
}
