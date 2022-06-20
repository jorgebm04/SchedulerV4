using SchedulerV4.Enums;
using System.Globalization;

namespace SchedulerV4.Descriptions
{
    public static class OnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    settings.Description = "Ocurre una vez. El planificador se usara el " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("es-ES")) + " a las " +
                        settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES"));
                    break;
                case (int)LanguageEnum.Language.EnglishUK:
                    settings.Description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-UK")) + " at " +
                        settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-UK"));
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.Description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-US")) + " at " +
                        settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US"));
                    break;
            }
        }
    }
}
