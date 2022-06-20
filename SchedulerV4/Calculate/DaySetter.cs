using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class DaySetter
    {
        public static string SetDay(Settings settings)
        {
            string day = "";
            switch (settings.DailyFreq)
            {
                case (int)DayFreqEnum.DayFreq.Monday:
                    day = DayLanguage.SetMondayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Tuesday:
                    day = DayLanguage.SetTuesdayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Wednesday:
                    day = DayLanguage.SetWednesdayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Thursday:
                    day = DayLanguage.SetThursdayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Friday:
                    day = DayLanguage.SetFridayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Saturday:
                    day = DayLanguage.SetSaturdayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Sunday:
                    day = DayLanguage.SetSundayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Day:
                    day = DayLanguage.SetDayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.Weekday:
                    day = DayLanguage.SetWeekDayInLanguage(settings);
                    break;
                case (int)DayFreqEnum.DayFreq.WeekendDay:
                    day = DayLanguage.SetWeekEndDayInLanguage(settings);
                    break;
            }
            return day;
        }
    }
}
