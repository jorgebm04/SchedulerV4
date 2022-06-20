using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class FreqSetter
    {
        public static String SetFreq(Settings settings)
        {
            string freq = "";
            switch (settings.MonthlyFreq)
            {
                case (int)OccursDayEnum.OccursDay.First:
                    freq = FreqLanguage.SetFreqFirstInLanguage(settings);
                    break;
                case (int)OccursDayEnum.OccursDay.Second:
                    freq = FreqLanguage.SetFreqSecondInLanguage(settings);
                    break;
                case (int)OccursDayEnum.OccursDay.Third:
                    freq = FreqLanguage.SetFreqThirdInLanguage(settings);
                    break;
                case (int)OccursDayEnum.OccursDay.Fourth:
                    freq = FreqLanguage.SetFreqFourthInLanguage(settings);
                    break;
                case (int)OccursDayEnum.OccursDay.Last:
                    freq = FreqLanguage.SetFreqLastInLanguage(settings);
                    break;
            }
            return freq;
        }
    }
}
