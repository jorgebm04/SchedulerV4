using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class FreqSetter
    {
        public static String SetFreq(Settings settings)
        {
            string freq;
            if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.First)
            {
                freq = FreqLanguage.SetFreqFirstInLanguage(settings);
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.Second)
            {
                freq = FreqLanguage.SetFreqSecondInLanguage(settings);
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.Third)
            {
                freq = FreqLanguage.SetFreqThirdInLanguage(settings);
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.Fourth)
            {
                freq = FreqLanguage.SetFreqFourthInLanguage(settings);
            }
            else
            {
                freq = FreqLanguage.SetFreqLastInLanguage(settings);
            }
            return freq;
        }
    }
}
