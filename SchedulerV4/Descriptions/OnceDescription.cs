using SchedulerV4.Enums;

namespace SchedulerV4.Descriptions
{
    public static class OnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    settings.Description = "Ocurre una vez. El planificador se usara el " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " a las " +
                        settings.CalculatedDate.ToString("HH:mm");
                    break;
                case (int)LanguageEnum.Language.EnglishUK:
                    settings.Description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                        settings.CalculatedDate.ToString("HH:mm");
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.Description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("MM'/'dd'/'yyyy") + " at " +
                        settings.CalculatedDate.ToString("HH:mm");
                    break;
            }
        }
    }
}
