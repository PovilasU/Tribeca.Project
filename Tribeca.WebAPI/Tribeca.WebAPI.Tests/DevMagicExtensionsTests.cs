using System;
using Xunit;
using Tribeca.WebAPI.Helpers;

namespace Tribeca.WebAPI.Tests
{
    public class DevMagicExtensionsTests
    {
        [Theory]
        [InlineData("2023-01-25", "Aquarius")]
        [InlineData("1990-05-15", "Taurus")]
        [InlineData("1987-11-03", "Scorpio")]
        // Add more test cases as needed
        public void StarSign_ReturnsCorrectSign(string birthDate, string expectedSign)

        {
            // Arrange
            string actualSign = birthDate.StarSign();

            // Assert
            Assert.Equal(expectedSign, actualSign);
        }

        [Fact]
        public void StarSign_ThrowsExceptionForInvalidDateFormat()
        {
            // Arrange
            string invalidDate = "invalid";

            // Act & Assert
            Assert.Throws<FormatException>(() => invalidDate.StarSign());
        }
    }
}
