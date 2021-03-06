using Xunit;
using FluentAssertions;
using SchedulerV4.Calculate;
using System.Globalization;

namespace SchedulerV4.Test.EnglishUS_Tests.Calculates_Tests
{
    public class CalculateOnceTests
    {
        private readonly CultureInfo _culture = new("en-US", true);

        [Fact]
        public void Validate_calculated_date_type_once()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 2,
                CurrentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                OnceTimeAt = new System.DateTime(2022, 05, 30, 14, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 30, 14, 0, 0);
            //Act
            CalculateOnce.CalculateNextExecutionTime(settings);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(expectedDate.ToString("g", _culture));
        }
    }
}
