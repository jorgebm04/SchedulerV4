using SchedulerV4.Calculate;
using SchedulerV4.Enums;
using System.Globalization;

namespace SchedulerV4.Descriptions
{
    public static class MonthlyTheEveryDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                String freq = FreqSetter.SetFreq(settings);
                String day = DaySetter.SetDay(settings);
                String freqTime = FreqTimeSetter.SetFreqTime(settings);
                switch (settings.Language)
                {
                    case (int)LanguageEnum.Language.Español:
                        settings.Description = "Ocurre el " + freq + " " + day + " de cada " + settings.NumMonths +
                            " meses. El planificador se usará el " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("es-ES")) + " a las " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES")) + " cada " + settings.OccursEveryFreq + " " + freqTime + " empezando el " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUK:
                        settings.Description = "Occurs the " + freq + " " + day + " of every " + settings.Monthly2Freq +
                            " months. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-UK")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-UK")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-UK"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUS:
                        settings.Description = "Occurs the " + freq + " " + day + " of every " + settings.Monthly2Freq +
                            " months. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-US")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-US"));
                        break;
                }
            }           
        }
    }
}
