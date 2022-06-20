namespace SchedulerV4.Calculate
{
    public static class CalculateOnce
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            settings.CalculatedDate = settings.OnceTimeAt;
        }
    }
}
