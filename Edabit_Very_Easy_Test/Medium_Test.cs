using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Medium_Test
    {

        [Theory]
        [InlineData("house", "fly", 11)]
        [InlineData("sharp", "sharq", 1)]
        [InlineData("abcde", "bcdef", 5)]
        [InlineData("abcde", "a", 4)]
        [InlineData("abcde", "e", 8)]
        [InlineData("abcde", "Abcde", 32)]
        [InlineData("abcde", "A", 36)]
        [InlineData("very", "fragile", 67)]
        public void ReturnLetterDistance(string str1, string str2, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.LetterDistance(str1, str2);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(43, "Oddish")]
        [InlineData(373, "Oddish")]
        [InlineData(55551, "Oddish")]
        [InlineData(694, "Oddish")]
        [InlineData(4433, "Evenish")]
        [InlineData(11, "Evenish")]
        [InlineData(211112, "Evenish")]
        public void ReturnOddishOrEvenish(int num, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.OddishOrEvenish(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 90)]
        [InlineData(2, 240)]
        [InlineData(3, 450)]
        [InlineData(4, 720)]
        [InlineData(5, 1050)]
        public void GuessSequence(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.GuessSequence(num);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1+1", 2)]
        [InlineData("7*4-2", 26)]
        [InlineData("1+1+1+1+1", 5)]
        public void  Equation(string s, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Equation(s);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Reverse", "esreveR")]
        [InlineData("This is a typical sentence.", "This is a lacipyt .ecnetnes")]
        [InlineData("The dog is big.", "The dog is big.")]
        [InlineData("Reverse the order of every word greater than or equal to five characters.", "esreveR the redro of yreve word retaerg than or lauqe to five .sretcarahc")]
        [InlineData("Lets all be unique together until we realise we are all the same.", "Lets all be euqinu rehtegot litnu we esilaer we are all the .emas")]
        public void ReturnReverse(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Reverse(str);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!", true)]
        [InlineData("Neuquen", true)]
        [InlineData("Not a palindrome", false)]
        public void IsPalindrome(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Medium.IsPalindrome(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 10, 10 }, 23)]
        [InlineData(new int[] { 3, 3 }, 7)]
        [InlineData(new int[] { -10, -9 }, 22)]
        [InlineData(new int[] { -1, -4 }, 5)]
        [InlineData(new int[] { -10, -2 }, 14)]
        [InlineData(new int[] { 3, 30 }, 39)]
        [InlineData(new int[] { 40, 1 }, 49)]
        [InlineData(new int[] { 3, 5 }, 9)]
        public void  NumberOfDays(int[] coordinates, int expected)
        {
            // Arrange

            // Actual
            var actual = Medium.NumberOfDays(coordinates);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcd", "A-Bb-Ccc-Dddd")]
        [InlineData("RqaEzty", "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy")]
        [InlineData("cwAt", "C-Ww-Aaa-Tttt")]
        [InlineData("VgyCdnQa", "V-Gg-Yyy-Cccc-Ddddd-Nnnnnn-Qqqqqqq-Aaaaaaaa")]
        [InlineData("nRBSdNOsMl", "N-Rr-Bbb-Ssss-Ddddd-Nnnnnn-Ooooooo-Ssssssss-Mmmmmmmmm-Llllllllll")]
        public void ReturnAccum(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Accum(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("potato", 1)]
        [InlineData("potatopotatocherry", 2)]
        [InlineData("potatopotatopotatoorange", 3)]
        [InlineData("potatopotatobananapotatopotato", 4)]
        [InlineData("potatopotatomangopotatopotatopotato", 5)]
        [InlineData("potatocucumberpotatopotatopotatopotatopotato", 6)]
        public void Potatoes(string potato, int expected)
        {
            // Arrange

            // Actual 
            var actual = Medium.Potatoes(potato);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("karaca", "0c0r0kaca")]
        [InlineData("burak", "k0r3baca")]
        [InlineData("alpaca", "0c0pl0aca")]
        [InlineData("banana", "0n0n0baca")]
        [InlineData("hello", "2ll1haca")]
        public void ReturnEncrypt(string word, string expected)
        {
            // Arrange

            // Actual
            var actual = Medium.Encrypt(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
    	[InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [InlineData(new int[] { 5, 3, 2, 1, 4 }, new int[] { 5, 3, 2, 4 })]
        [InlineData(new int[] { 2, 2, 1, 2, 1 }, new int[] { 2, 2, 2, 1 })]
        [InlineData(new int[] { 3, 1, 6, 7, 3, 7, 6 }, new int[] { 3, 6, 7, 3, 7, 6 })]
        [InlineData(new int[] { 4, 4, 4, 1 }, new int[] { 4, 4, 4 })]
        [InlineData(new int[] { 5, 4, 5, 3, 1, 1 }, new int[] { 5, 4, 5, 3, 1 })]
        [InlineData(new int[] { 1, 5, 3 }, new int[] { 5, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 6, 2, 5, 4, 8, 6, 3, 2, 7 }, new int[] { 6, 5, 4, 8, 6, 3, 2, 7 })]
        [InlineData(new int[] { 3 }, new int[] { })]
        public void ReturnRemoveSmallest(int[] values, int[] expected)
        {
        // Arrange

        // Actual
        var actual = Medium.RemoveSmallest(values);
        
        // Assert
        Assert.Equal(expected, actual);
        }

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
