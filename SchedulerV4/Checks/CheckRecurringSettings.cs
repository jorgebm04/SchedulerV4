﻿using SchedulerV4.Enums;

namespace SchedulerV4.Checks
{
    public static class CheckRecurringSettings
    {
        public static void CheckSettings(Settings settings)
        {
            switch (settings.Occurs)
            {
                case (int)OccursEnum.Occurs.Daily:
                    CheckDailySettings.CheckRecurringDailySettings(settings);
                    break;
                case (int)OccursEnum.Occurs.Monthly:
                    CheckMonthlySettings.CheckRecurrentMonthlySettings(settings);
                    break;
                default:
                    settings.NextExecutionTime = "Select and occurrence.";
                    break;
            }
        }
    }
}
