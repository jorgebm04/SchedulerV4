using FluentAssertions;
using SchedulerV4.Checks;
using SchedulerV4.Descriptions;
using System;
using System.Globalization;
using Xunit;

namespace SchedulerV4.Test.EnglishUS_Tests.Checks_Tests
{
    public class CheckOnceSettingsTests
    {
        private readonly CultureInfo culture = new("en-US");

        [Fact]
        public void Validate_incorrect_current_date_checker_settings()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 1, 1, 0, 0, 0)
            };
            //Act
            CheckOnceSettings.CheckSettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Current date not correct.");
        }

        [Fact]
        public void Validate_once_description()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CalculatedDate = new DateTime(2022, 06, 16, 10, 0, 0)
            };
            //Act
            OnceDescription.SetDescription(settings);
            //Assert
            settings.Description.Should().BeEquivalentTo("Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("d", culture) + " at " +
                        settings.CalculatedDate.ToString("t", culture));
        }

        [Fact]
        public void Validate_incorrect_once_time_at_date_checker_settings()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = DateTime.Now,
                OnceTimeAt = new DateTime(2022,1,1,0,0,0)
            };
            //Act
            CheckOnceSettings.CheckSettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Once time at date not valid");
        }

        [Fact]
        public void Validate_correct_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = DateTime.Now
            };
            //Act
            bool result = CurrentDateChecker.CheckCurrentDate(settings.CurrentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2000, 1, 1, 0, 0, 0)
            };
            //Act
            bool result = CurrentDateChecker.CheckCurrentDate(settings.CurrentDate);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 05, 20, 15, 0, 0),
                OnceTimeAt = new DateTime(2022, 05, 30, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.CurrentDate, settings.OnceTimeAt);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 05, 20, 15, 0, 0),
                OnceTimeAt = new DateTime(2022, 05, 10, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.CurrentDate, settings.OnceTimeAt);
            //Assert
            result.Should().BeFalse();
        }
    }
}