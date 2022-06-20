using SchedulerV4.Enums;
using System.Globalization;

namespace SchedulerV4.Descriptions
{
    public static class MonthlyDayOnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                switch (settings.Language)
                {
                    case (int)LanguageEnum.Language.Español:
                        settings.Description = "Ocurre cada dia " + settings.NumDay + " cada " + settings.NumMonths +
                            " meses. El planificador se usará a las " + settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES")) + ", empezando el " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUK:
                        settings.Description = "Occurs every " + settings.NumDay + " day, every " + settings.NumMonths +
                            " months. Schedule will be used at " + settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-UK")) + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-UK"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUS:
                        settings.Description = "Occurs every " + settings.NumDay + " day, every " + settings.NumMonths +
                            " months. Schedule will be used at " + settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US")) + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-US"));
                        break;
                }
            }   
        }
    }
}
