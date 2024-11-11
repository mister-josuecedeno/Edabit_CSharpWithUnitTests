using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Medium_Test
    {

        [Theory]
        [InlineData("What went wrong?????????", "What went wrong?")]
        [InlineData("Oh my goodness!!!", "Oh my goodness!")]
        [InlineData("WHAT!", "WHAT!")]
        [InlineData("WHAT?", "WHAT?")]
        [InlineData("Oh my goodness!", "Oh my goodness!")]
        [InlineData("I just cannot believe it.", "I just cannot believe it.")]
        public void NoYelling(string phrase, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.NoYelling(phrase);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(152, 10)]
        [InlineData(832, 48)]
        [InlineData(5511, 25)]
        [InlineData(19, 9)]
        [InlineData(133, 9)]
        public void ReturnMysteryFunc(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.MysteryFunc(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4", 2, true)]
        [InlineData("387420489", 9, true)]
        [InlineData("302875106592253", 13, true)]
        [InlineData("341427877364219557396646723584", 22, true)]
        [InlineData("1330877630632711998713399240963346255985889330161650994325137953641", 41, true)]
        public void ReturnKToK(string n, int k, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.KToK(n, k);
            
            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
