using SchedulerV4.Enums;

namespace SchedulerV4.Calculate
{
    public static class FreqTimeSetter
    {
        public static string SetFreqTime(Settings settings)
        {
            string freqTime = "";
            switch (settings.Freq)
            {
                case (int)FreqEnum.Frequency.Hours:
                    freqTime = FreqTimeLanguage.SetHoursInLanguage(settings);
                    break;
                case (int)FreqEnum.Frequency.Minutes:
                    freqTime = FreqTimeLanguage.SetMinutesInLanguage(settings);
                    break;
                case (int)FreqEnum.Frequency.Seconds:
                    freqTime = FreqTimeLanguage.SetSecondsInLanguage(settings);
                    break;
            }
            return freqTime;
        }
    }
}
