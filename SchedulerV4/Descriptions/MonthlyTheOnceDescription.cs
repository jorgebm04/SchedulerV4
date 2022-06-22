using SchedulerV4.Calculate;
using SchedulerV4.Enums;
using System.Globalization;

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
                            " El planificador se usará el " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("es-ES")) + " a las " + 
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES")) + " empezando el " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                        break;
                    case (int)LanguageEnum.Language.EnglishGb:
                        settings.Description = "Occurs the " + freq + " " + day + " of every " + settings.Monthly2Freq + " months." +
                            " Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-GB")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-GB")) + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-GB"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUs:
                        settings.Description = "Occurs the " + freq + " " + day + " of every " + settings.Monthly2Freq + " months." +
                            " Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-US")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US")) + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-US"));
                        break;
                }
            }
        }
    }
}
