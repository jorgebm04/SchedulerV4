using SchedulerV4.Calculate;
using SchedulerV4.Enums;

namespace SchedulerV4.Descriptions
{
    public static class MonthlyTheOnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                String freq = FreqSetter.SetFreq(settings);
                String day = DaySetter.SetDay(settings);
                switch (settings.Language)
                {
                    case (int)LanguageEnum.Language.Español:
                        settings.Description = "Ocurre el " + freq + " " + day + " cada " + settings.Monthly2Freq + " meses." + 
                            " El planificador se usará el " + settings.CalculatedDate.ToString("dd/MM/yyyy") + " a las " + 
                            settings.CalculatedDate.ToString("HH:mm") + " empezando el " + settings.StartingLimit.ToString("dd/MM/yyyy");
                        break;
                    case (int)LanguageEnum.Language.EnglishUK:
                        settings.Description = "Occurs the " + freq + " " + day + " of every " + settings.Monthly2Freq + " months." +
                            " Schedule will be used on " + settings.CalculatedDate.ToString("dd/MM/yyyy") + " at " +
                            settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("dd/MM/yyyy");
                        break;
                    case (int)LanguageEnum.Language.EnglishUS:
                        settings.Description = "Occurs the " + freq + " " + day + " of every " + settings.Monthly2Freq + " months." +
                            " Schedule will be used on " + settings.CalculatedDate.ToString("MM/dd/yyyy") + " at " +
                            settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("MM/dd/yyyy");
                        break;
                }
            }
        }
    }
}
