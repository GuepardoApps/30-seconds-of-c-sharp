using FluentAssertions;
using System;
using Xunit;

namespace Conplement.Snippets.Date.Test
{
    public class DateDayOfYearUnitTest
    {
        [Fact]
        public void DayOfYear_ShouldReturnExpectedResult_ForToday()
        {
            // Arrange
            var dayOfYearToday = DateTime.Now.DayOfYear;

            // Act
            var snippetResult = Date.DayOfYear();

            // Assert
            snippetResult.Should().Be(dayOfYearToday);
        }
    }
}
