using Xunit;
using FluentAssertions;
using SchedulerV4.Calculate;
using System.Globalization;

namespace SchedulerV4.Test.EnglishUS_Tests.Calculates_Tests
{
    public class CalculateRecurringDailyOnceTests
    {
        private readonly CultureInfo culture = new("en-US");

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                Occurs = 0,
                OccursOnceAt = true,
                OccursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                NeedToAddDay = false
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 14, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExeccutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", culture));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_occurs_once_over_time()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 14, 10, 0),
                Occurs = 0,
                OccursOnceAt = true,                
                OccursOnceAtHour = new System.DateTime(2022, 05, 27, 8, 0, 0),
                NeedToAddDay = true
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 8, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            var result = NextExecutionTimeFormatter.SetNextExeccutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", culture));
        }
    }
}
