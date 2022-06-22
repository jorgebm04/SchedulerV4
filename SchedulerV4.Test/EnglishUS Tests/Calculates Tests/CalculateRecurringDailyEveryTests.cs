﻿using Xunit;
using FluentAssertions;
using SchedulerV4.Calculate;
using System.Globalization;

namespace SchedulerV4.Test.EnglishUS_Tests.Calculates_Tests
{
    public class CalculateRecurringDailyEveryTests
    {
        private readonly CultureInfo _culture = new("en-US", true);

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour_in_limits()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 12, 10, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 13, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour_in_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 12, 15, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2022, 05, 27, 12, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 12, 30, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 12, 30, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 12, 15, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = true,
                StartingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute_in_limits()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 12, 10, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 12, 30, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute_in_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 12, 10, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2022, 05, 27, 12, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 12, 15, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 12, 15, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 12, 15, 0),
                Occurs = 0,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 1,
                NeedToAddDay = true,
                StartingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 05, 27, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }
    }
}
