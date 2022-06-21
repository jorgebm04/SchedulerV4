using SchedulerV4.Calculate;
using SchedulerV4.Enums;
using System.Globalization;

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
                    settings.Description = "Ocurre cada dia. El planificador se usara el " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("es-ES")) + " a las " +
                        settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES")) + " cada " + settings.OccursEveryFreq + " " + freqTime + " empezando el " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                    break;
                case (int)(LanguageEnum.Language.EnglishGB):
                    settings.Description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-GB")) + " at " + 
                        settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-GB")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-GB"));
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    settings.Description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-US")) + " at " +
                        settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-US"));
                    break;
            }
        }
    }
}
