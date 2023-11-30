using System;
using Tribeca.WebAPI.Helpers;
using Xunit;

namespace Tribeca.WebAPI.Tests
{
    public class DevMagicServiceTests
    {
        [Fact]
        public void TransformToDevMagic_TransformsEnglishToDevMagic()
        {
            // Arrange
            var devMagicService = new DevMagicService();
            var input = "Hello world!";

            // Act
            var result = devMagicService.TransformToDevMagic(input);

            // Assert
            Assert.Equal("elloyay orldway!", result);
        }

        [Fact]
        public void TransformFromDevMagic_TransformsDevMagicToEnglish()
        {
            // Arrange
            var devMagicService = new DevMagicService();
            var input = "elloyay orldway!";

            // Act
            var result = devMagicService.TransformFromDevMagic(input);

            // Assert
            Assert.Equal("Hello world!", result);
        }

        [Theory]
        [InlineData("appyhay", "happy")]
        [InlineData("Yappleay", "apple")]
        [InlineData("Y", "")]
        public void TransformWordToEng_TransformsDevMagicToEnglish(string input, string expected)
        {
            // Arrange
            var devMagicService = new DevMagicService();

            // Act
            var result = devMagicService.TransformWordToEng(input);

            // Assert
            Assert.Equal(expected, result);
        }
   
    }
}
