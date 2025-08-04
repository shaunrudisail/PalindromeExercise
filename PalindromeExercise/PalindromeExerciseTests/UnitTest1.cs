using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("rotator", true)]
        [InlineData("kayak", true)]
        [InlineData("apple", false)]
        [InlineData("jump", false)]
        [InlineData("generator", false)]
        [InlineData("traffic", false)]

        public void TestPalindrome(string word, bool expected)
        {
            //Arrange
            var palindrome = new WordSmith();
            
            //Act
            var actual = palindrome.IsAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
