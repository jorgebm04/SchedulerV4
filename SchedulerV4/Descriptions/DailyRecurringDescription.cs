using SchedulerV4.Enums;

namespace SchedulerV4.Descriptions
{
    public static class DailyRecurringDescription
    {
        public static void SetDescription(Settings settings)
        {
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    settings.Description = "Ocurre cada dia. El planificador se usará el " + settings.CalculatedDate.ToString("dd/MM/yyyy") + " a las " +
                        settings.CalculatedDate.ToString("HH:mm") + " empezando el " + settings.StartingLimit.ToString("dd/MM/yyyy");
                    break;
                case (int)LanguageEnum.Language.EnglishUK:
                    settings.Description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("dd/MM/yyyy") + " at " + 
                        settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("dd/MM/yyyy");
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.Description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("MM/dd/yyyy") + " at " +
                        settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("MM/dd/yyyy");
                    break;
            }
            
        }
            
    }
}
