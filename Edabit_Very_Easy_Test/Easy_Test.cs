using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Easy_Test
    {
        [Theory]
        [InlineData("Hello", "{ LETTERS = 5, DIGITS = 0 }")]
        [InlineData("137", "{ LETTERS = 0, DIGITS = 3 }")]
        [InlineData("H3LL0", "{ LETTERS = 3, DIGITS = 2 }")]
        [InlineData("149990", "{ LETTERS = 0, DIGITS = 6 }")]
        [InlineData("edabit 2018", "{ LETTERS = 6, DIGITS = 4 }")]
        [InlineData("    ", "{ LETTERS = 0, DIGITS = 0 }")]
        public void ReturnCount_all(string txt, string expected)
        {
            // Arrange

            // Act
            var actual = Easy.count_all(txt);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("eDaBiT", new int[] { 1, 3, 5 })]
        [InlineData("eQuINoX", new int[] { 1, 3, 4, 6 })]
        [InlineData("determine", new int[] { })]
        [InlineData("STRIKE", new int[] { 0, 1, 2, 3, 4, 5 })]
        public void ReturnIndexOfCapitals(string str, int[] expected)
        {
            // Arrange

            // Act
            var actual = Easy.IndexOfCapitals(str);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 }, new double[] { 1, 3, 6 })]
        [InlineData(new double[] { -1, -2, -3 }, new double[] { -1, -3, -6 })]
        [InlineData(new double[] { 1, -2, 3 }, new double[] { 1, -1, 2 })]
        public void CumulativeSum(double[] arr, double[] expected)
        {
            // Arrange

            // Act
            var actual = Easy.CumulativeSum(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, 4 }, 5)]
        [InlineData(new int[] { 0, 0, -10 }, 10)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 2, 3, 6, 1, 8 }, 10.677078252031311)]
        [InlineData(new int[] { 9, -9, 3 }, 13.076696830622021)]
        [InlineData(new int[] { -24, 94, 4, 0, 10 }, 97.61147473529944)]
        public void Magnitude(int[] arr, double expected)
        {
            // Arrange

            // Act
            var actual = Easy.Magnitude(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(",1|2)\")A^1<[_)?^\"]l[a`3+%!d@8-0_0d.*}i@&n?=", "Aladdin")]
        [InlineData("^U)6$22>8p).", "Up")]
        [InlineData("I5n!449+c@e*}@@1]p{2@`,~t:i0o%n<3%8", "Inception")]
        [InlineData("!)\"P[s9)\"69}yc3+?1]+33>3ho", "Psycho")]
        public void ReturnLettersOnly(string str, string expected)
        {
            // Arrange

            // Act
            var actual = Easy.LettersOnly(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new double[] { 1, 5, 8, 2, 3, 4, 4, 4, 10 },
            new double[] { 1, 2, 3, 4, 5, 8, 10 }
        )]
        [InlineData(new double[] { 1, 2, 5, 4, 7, 7, 7 }, new double[] { 1, 2, 4, 5, 7 })]
        [InlineData(
            new double[] { 7, 6, 5, 4, 3, 2, 1, 0, 1 },
            new double[] { 0, 1, 2, 3, 4, 5, 6, 7 }
        )]
        public void ReturnUniqueSort(double[] arr, double[] expected)
        {
            // Arrange

            // Act
            var actual = Easy.UniqueSort(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("59001", true)]
        [InlineData("853a7", false)]
        [InlineData("732 32", false)]
        [InlineData("788876", false)]
        [InlineData("a923b", false)]
        [InlineData("5923!", false)]
        [InlineData("59238aa", false)]
        [InlineData("88231", true)]
        public void ReturnIsValid(string zip, bool expected)
        {
            // Arrange

            // Act
            var actual = Easy.IsValid(zip);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
