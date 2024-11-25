using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Medium_Test
    {

        [Theory]
        [InlineData("I am a title", "I Am A Title")]
        [InlineData("I AM A TITLE", "I AM A TITLE")]
        [InlineData("i aM a tITLE", "I AM A TITLE")]
        [InlineData("the first letter of every word is capitalized", "The First Letter Of Every Word Is Capitalized")]
        public void ReturnMakeTitle(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.MakeTitle(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("@edabit.com", false)]
        [InlineData("@edabit", false)]
        [InlineData("matt@edabit.com", true)]
        [InlineData("", false)]
        [InlineData("hello.gmail@com", false)]
        [InlineData("bill.gates@microsoft.com", true)]
        public void ReturnValidateEmail(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.ValidateEmail(str);

            // Actual
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("What went wrong?????????", "What went wrong?")]
        [InlineData("Oh my goodness!!!", "Oh my goodness!")]
        [InlineData("WHAT!", "WHAT!")]
        [InlineData("WHAT?", "WHAT?")]
        [InlineData("Oh my goodness!", "Oh my goodness!")]
        [InlineData("I just cannot believe it.", "I just cannot believe it.")]
        [InlineData("I just!!! can!!! not!!! believe!!! it!!!", "I just!!! can!!! not!!! believe!!! it!")]
        [InlineData("That's a ton!! of cheese!!!!", "That's a ton!! of cheese!")]
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
