using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class CalculateNewDay
    {
        public static DateTime CalNewDate(Settings settings)
        {
            DateTime result = new (2020,1,1,0,0,0);
            switch (settings.DailyFreq)
            {
                case (int)DayFreqEnum.DayFreq.Monday:
                    DayOfWeek day = DayOfWeek.Monday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Tuesday:
                    day = DayOfWeek.Tuesday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Wednesday:
                    day = DayOfWeek.Wednesday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Thursday:
                    day = DayOfWeek.Thursday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Friday:
                    day = DayOfWeek.Friday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Saturday:
                    day = DayOfWeek.Saturday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Sunday:
                    day = DayOfWeek.Sunday;
                    result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Day:
                    result = CalculateTheDay.CalculateDay(settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.Weekday:
                    result = CalculateTheDay.CalculateWeekday(settings.CurrentDate, settings.MonthlyFreq);
                    break;
                case (int)DayFreqEnum.DayFreq.WeekendDay:
                    result = CalculateTheDay.CalculateWeekendDay(settings.CurrentDate, settings.MonthlyFreq);
                    break;
            }
            return result;
        }
    }
}
