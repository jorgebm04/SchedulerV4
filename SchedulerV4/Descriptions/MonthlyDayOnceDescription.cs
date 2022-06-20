﻿using SchedulerV4.Enums;

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
                            " meses. El planificador se usará a las " + settings.CalculatedDate.ToString("HH:mm") + ", empezando el " + settings.StartingLimit.ToString("dd/MM/yyyy");
                        break;
                    case (int)LanguageEnum.Language.EnglishUK:
                        settings.Description = "Occurs every " + settings.NumDay + " day, every " + settings.NumMonths +
                            " months. Schedule will be used at " + settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("dd/MM/yyyy");
                        break;
                    case (int)LanguageEnum.Language.EnglishUS:
                        settings.Description = "Occurs every " + settings.NumDay + " day, every " + settings.NumMonths +
                            " months. Schedule will be used at " + settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("MM/dd/yyyy");
                        break;
                }
            }   
        }
    }
}