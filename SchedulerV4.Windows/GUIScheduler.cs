using SchedulerV4.Calculate;
using SchedulerV4.Checks;
using SchedulerV4.Descriptions;
using SchedulerV4.Enums;
using System.Globalization;

namespace SchedulerV4.Windows
{
    public partial class GUIScheduler : Form
    {
        public GUIScheduler()
        {
            InitializeComponent();
        }

        private void FillSettings(object sender, EventArgs e)
        {
            nextExecutionTimeTextBox.Text = "";
            descriptionTextBox.Text = "";
            Settings settings = new()
            {
                CurrentDate = currentDateDateTimePicker.Value,
                Type = typeComboBox.SelectedIndex,
                OnceTimeAt = onceTimeAtDateTimePicker.Value,
                Occurs = occursComboBox.SelectedIndex,
                Day = dayRadioButton.Checked,
                NumDay = (int)numDaysUpDown.Value,
                NumMonths = (int)everyUpDown.Value,
                The = theRadioButton.Checked,
                MonthlyFreq = monthFrecuencyComboBox.SelectedIndex,
                DailyFreq = monthDaysComboBox.SelectedIndex,
                Monthly2Freq = (int)ofEveryUpDown.Value,
                OccursOnceAt = occursOnceAtRadioButton.Checked,
                OccursOnceAtHour = occursOnceAtDateTimePicker.Value,
                OccursEvery = occursEveryRadioButton.Checked,
                OccursEveryFreq = (int)occursEveryNumericUpDown.Value,
                Freq = occursEveryComboBox.SelectedIndex,
                StartingHour = startingAtDateTimePicker.Value,
                EndingHour = endingAtDateTimePicker.Value,
                StartingLimit = startLimitDateTimePicker.Value,
                EndingLimit = endLimitDateTimePicker.Value,
                FreqTime = occursEveryComboBox.Text,
                IsOverLimit = false,
                Language = languageComboBox.SelectedIndex
            };
            CheckSettings(settings);
        }

        private void CheckSettings(Settings settings)
        {
            if (!enabledCheckBox.Checked)
            {
                nextExecutionTimeTextBox.Text = @"Scheduler not enabled";
                return;
            }
            bool language = LanguageChecker.CheckLanguage(settings);
            if (!language)
            {
                nextExecutionTimeTextBox.Text = @"Language not selected.";
                return;
            }
            switch (settings.Type)
            {
                case (int)TypeEnum.Types.Once:
                    CheckOnceSettings.CheckSettings(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CheckRecurringSettings.CheckSettings(settings);
                    break;
                default:
                    settings.NextExecutionTime = "Please select a type";
                    break;
            }
            nextExecutionTimeTextBox.Text = settings.NextExecutionTime;

            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (settings.NextExecutionTime.Length == 0)
            {
                CalculateNextDate(settings);
            }
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void CalculateNextDate(Settings settings)
        {
            switch (settings.Type)
            {
                case (int)TypeEnum.Types.Once:
                    CalculateOnce.CalculateNextExecutionTime(settings);
                    OnceDescription.SetDescription(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CalculateRecurring.Calculate(settings);
                    break;
            }
            nextExecutionTimeTextBox.Text = NextExecutionTimeFormatter.SetNextExeccutionTimeFormat(settings,settings.CalculatedDate);
            descriptionTextBox.Text = settings.Description;
        }

        private void LanguageSettings(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case (int)LanguageEnum.Language.Espa�ol:
                    currentDateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
                    onceTimeAtDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
                    occursOnceAtDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
                    startingAtDateTimePicker.CustomFormat = "HH:mm";
                    endingAtDateTimePicker.CustomFormat = "HH:mm";
                    startLimitDateTimePicker.CustomFormat = "dd/MM/yyyy";
                    endLimitDateTimePicker.CustomFormat = "dd/MM/yyyy";
                    break;
                case (int)LanguageEnum.Language.EnglishGB:
                    currentDateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
                    onceTimeAtDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
                    occursOnceAtDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
                    startingAtDateTimePicker.CustomFormat = "HH:mm";
                    endingAtDateTimePicker.CustomFormat = "HH:mm";
                    startLimitDateTimePicker.CustomFormat = "dd/MM/yyyy";
                    endLimitDateTimePicker.CustomFormat = "dd/MM/yyyy";
                    break;
                case (int)LanguageEnum.Language.EnglishUS:
                    currentDateDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
                    onceTimeAtDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
                    occursOnceAtDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
                    startingAtDateTimePicker.CustomFormat = "HH:mm";
                    endingAtDateTimePicker.CustomFormat = "HH:mm";
                    startLimitDateTimePicker.CustomFormat = "MM/dd/yyyy";
                    endLimitDateTimePicker.CustomFormat = "MM/dd/yyyy";
                    break;
            }
        }

        private void TypeSettings(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = true;
                occursComboBox.Enabled = false;
                numDaysUpDown.ReadOnly = true;
                everyUpDown.ReadOnly = true;
                monthFrecuencyComboBox.Enabled = false;
                monthDaysComboBox.Enabled = false;
                ofEveryUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = false;
                occursEveryNumericUpDown.ReadOnly = true;
                occursEveryComboBox.Enabled = false;
                startingAtDateTimePicker.Enabled = false;
                endingAtDateTimePicker.Enabled = false;
                startLimitDateTimePicker.Enabled = false;
                endLimitDateTimePicker.Enabled = false;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = false;
                everyUpDown.ReadOnly = false;
                monthFrecuencyComboBox.Enabled = true;
                monthDaysComboBox.Enabled = true;
                ofEveryUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }

        private void OccursSettings(object sender, EventArgs e)
        {
            if (occursComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = true;
                everyUpDown.ReadOnly = true;
                monthFrecuencyComboBox.Enabled = false;
                monthDaysComboBox.Enabled = false;
                ofEveryUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = false;
                everyUpDown.ReadOnly = false;
                monthFrecuencyComboBox.Enabled = true;
                monthDaysComboBox.Enabled = true;
                ofEveryUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }
    }
}