using System;
using Tribeca.WebAPI.Helpers;
using Xunit;

namespace Tribeca.WebAPI.Tests
{
    public class DevMagicServiceTests
    {
        [Theory]
        [InlineData('a', true)]
        [InlineData('e', true)]
        [InlineData('i', true)]
        [InlineData('o', true)]
        [InlineData('u', true)]
        [InlineData('A', true)]
        [InlineData('E', true)]
        [InlineData('I', true)]
        [InlineData('O', true)]
        [InlineData('U', true)]
        [InlineData('b', false)]
        [InlineData('x', false)]
        [InlineData('Y', false)]
        [InlineData('1', false)]
        [InlineData('!', false)]
        public void IsVowel_ShouldReturnExpectedResult(char input, bool expectedResult)
        {
            // Arrange
            DevMagicService devMagicService = new DevMagicService(); // Assuming you have an instance of DevMagicService

            // Act
            bool result = devMagicService.IsVowel(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("hello", "hello")]               // No '!' present, should return the same word
        [InlineData("world!", "world!")]             // '!' at the end, should return the same word
        [InlineData("amazing!", "amazing!")]         // '!' in the middle, should return the same word
        [InlineData("awesome!!", "awesome!!")]       // Multiple '!' at the end, should not remove duplicates
        [InlineData("!!great!!", "great!!!!")]         // Multiple '!' at the beginning and end, should remove duplicates
        [InlineData("!!!", "!!!")]                   // Only '!' present, should return the same word
        [InlineData("", "")]                         // Empty string, should return an empty string
        [InlineData("exci!!ting!", "exciting!!!")]   // Multiple '!' in the middle, should not remove duplicates
        [InlineData("!!", "!!")]                     // Only '!' present, should return the same word
        public void ProcessTransformedWord_ShouldReturnExpectedResult(string input, string expectedResult)
        {
            // Arrange
            DevMagicService devMagicService = new DevMagicService(); // Assuming you have an instance of DevMagicService

            // Act
            string result = devMagicService.ProcessTransformedWord(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("hello", "ellohay")]         
        [InlineData("world", "orldway")]          
        [InlineData("DevMagic", "evMagicDay")]                      
        [InlineData("b", "bay")]         
        [InlineData("!start", "artstay!")]       
        [InlineData("duck", "uckday")]        
        [InlineData("move", "ovemay")]        
        [InlineData("scratch", "atchscray")]        
        public void TransformConsonantStartingWord_ShouldReturnExpectedResult(string input, string expectedResult)
        {
            // Arrange
            DevMagicService devMagicService = new DevMagicService(); // Assuming you have an instance of DevMagicService

            // Act
            string result = devMagicService.TransformConsonantStartingWord(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("hello", 1)]       // 'e' is the first vowel at index 1
        [InlineData("world", 1)]       // 'o' is the first vowel at index 1
        [InlineData("xyz", -1)]        // No vowels, should return -1
        [InlineData("AEIOU", 0)]        // 'A' is the first vowel at index 0
        [InlineData("", -1)]            // Empty string, should return -1
        [InlineData("b", -1)]           // Single consonant, should return -1
        [InlineData("banana", 1)]      // 'a' is the first vowel at index 1
        [InlineData("!start", 3)]      // 'a' is the first vowel at index 3 (excluding '!')
        [InlineData("rhythm", -1)]      // No vowels, should return -1
        public void FindFirstVowelIndex_ShouldReturnExpectedResult(string input, int expectedIndex)
        {
            // Arrange
            DevMagicService devMagicService = new DevMagicService(); // Assuming you have an instance of DevMagicService

            // Act
            int result = devMagicService.FindFirstVowelIndex(input);

            // Assert
            Assert.Equal(expectedIndex, result);
        }

        [Theory]         
        [InlineData("Yellow", "ellowyay")]         
        [InlineData("Year", "earyay")]         
        [InlineData("Dyke", "ykeday")]          
        [InlineData("Rhythm", "ythmrhay")]          
        public void TransformYStartingWord_ShouldReturnExpectedResult(string input, string expectedResult)
        {
            // Arrange
            DevMagicService devMagicService = new DevMagicService(); // Assuming you have an instance of DevMagicService

            // Act
            string result = devMagicService.TransformYStartingWord(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
