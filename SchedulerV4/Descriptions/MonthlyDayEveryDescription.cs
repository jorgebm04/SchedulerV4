using SchedulerV4.Calculate;
using SchedulerV4.Enums;
using System.Globalization;

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
                        settings.Description = "Ocurre cada dia " + settings.NumDay + " cada " + settings.NumMonths + " meses. El planificador se usará el " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("es-ES")) + " a las " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES")) + " cada " + settings.OccursEveryFreq + " " + freqTime + " empezando el " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUK:
                        settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + " months. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-UK")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-UK")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-UK"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUS:
                        settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + " months. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-US")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-US"));
                        break;
                }
            }
        }           
    }
}
