using FluentAssertions;
using SchedulerV4.Checks;
using Xunit;

namespace SchedulerV4.Test.EnglishGB_Tests.Checks_Tests
{
    public class CheckLanguageTests
    {
        [Fact]
        public void Validate_language_selected()
        {
            //Arrange
            var settings = new Settings
            {
                Language = 1,
            };
            //Act
            bool result = LanguageChecker.CheckLanguage(settings);
            //
            result.Should().BeTrue();   
        }

        [Fact]
        public void Validate_languge_not_selected()
        {
            //Arrange
            var settings = new Settings
            {
                Language = -1,
            };
            //Act
            bool result = LanguageChecker.CheckLanguage(settings);
            //
            result.Should().BeFalse();
        }
    }
}
