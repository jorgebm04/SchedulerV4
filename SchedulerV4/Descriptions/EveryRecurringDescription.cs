using SchedulerV4.Calculate;
using SchedulerV4.Enums;

namespace SchedulerV4.Descriptions
{
    public static class EveryRecurringDescription
    {
        public static void SetDescription(Settings settings)
        {
            String freqTime = FreqTimeSetter.SetFreqTime(settings);
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    settings.Description = "Ocurre cada dia. El planificador se usara el " + settings.CalculatedDate.ToString("dd/MM/yyyy") + " a las " +
                        settings.CalculatedDate.ToString("HH:mm") + " cada " + settings.OccursEveryFreq + " " + freqTime + " empezando el " + settings.StartingLimit.ToString("dd/MM/yyyy");
                    break;
                case (int)(LanguageEnum.Language.EnglishUK):
                    settings.Description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("dd/MM/yyyy") + " at " + 
                        settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("dd/MM/yyyy");
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.Description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("MM/dd/yyyy") + " at " +
                        settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("MM/dd/yyyy");
                    break;
            }
        }
    }
}
