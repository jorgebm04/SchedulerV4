namespace SchedulerV4.Checks
{
    public static class LanguageChecker
    {
        public static bool CheckLanguage(Settings settings)
        {
            if(settings.Language == -1)
            {
                return false;
            }
            return true;
        }
    }
}
