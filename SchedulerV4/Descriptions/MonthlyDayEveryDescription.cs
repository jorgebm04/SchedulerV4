using SchedulerV4.Calculate;
using SchedulerV4.Enums;

namespace SchedulerV4.Descriptions
{
    public static class MonthlyDayEveryDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                String freqTime = FreqTimeSetter.SetFreqTime(settings);
                switch (settings.Language){
                    case (int)LanguageEnum.Language.Español:
                        settings.Description = "Ocurre cada dia " + settings.NumDay + " cada " + settings.NumMonths + " meses. El planificador se usará el " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " a las " +
                            settings.CalculatedDate.ToString("HH:mm") + " cada " + settings.OccursEveryFreq + " " + freqTime + " empezando el " + settings.StartingLimit.ToString("dd/MM/yyyy");
                        break;
                    case (int)LanguageEnum.Language.EnglishUK:
                        settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + " months. Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                            settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("dd/MM/yyyy");
                        break;
                    case (int)LanguageEnum.Language.EnglishUS:
                        settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + " months. Schedule will be used on " + settings.CalculatedDate.ToString("MM'/'dd'/'yyyy") + " at " +
                            settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("MM/dd/yyyy");
                        break;
                }
            }
        }           
    }
}
