using System;
using Xunit;
using ReverseWords;

namespace ReverseWords.Tests
{
    public class ReverseWordTests
    {
        [Fact]
        public void ReverseWords_TestCase1()
        {
            // Arrange
            string input = "csharp is programming language";
            string expected = "language programming is csharp";

            // Act
            string result = ReverseWord.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseWords_TestCase2()
        {
            // Arrange
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";

            // Act
            string result = ReverseWord.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseWords_TestCase3()
        {
            // Arrange
            string input = "challenges and data structures";
            string expected = "structures data and challenges";

            // Act
            string result = ReverseWord.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
