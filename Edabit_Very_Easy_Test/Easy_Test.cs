﻿using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel.DataAnnotations;

namespace Edabit.Tests
{
    public class Easy_Test
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 16)]
        [InlineData(8, 141)]
        [InlineData(10, 226)]
        [InlineData(15, 526)]
        [InlineData(33, 2641)]
        public void ReturnPentagonal(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Easy.Pentagonal(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("(123) 456-7890", true)]
        [InlineData("(1111)555 2345", false)]
        [InlineData("(098) 123 4567", false)]
        [InlineData("(123)456-7890", false)]
        public void ReturnIsValidPhoneNumber(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.IsValidPhoneNumber(str);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
    	[InlineData(new int[] { 1, 2, 3, 4, 5}, new int[] { 2, 3, 4, 5})]
        [InlineData(new int[] { 5, 3, 2, 1, 4 }, new int[] { 5, 3, 2, 4 })]
        [InlineData(new int[] { 2, 2, 1, 2, 1 }, new int[] { 2, 2, 2, 1 })]
        [InlineData(new int[] { 3, 1, 6, 7, 3, 7, 6 }, new int[] { 3, 6, 7, 3, 7, 6 })]
        [InlineData(new int[] { 4, 4, 4, 1 }, new int[] { 4, 4, 4 })]
        public void ReturnRemoveSmallest(int[] values, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Easy.RemoveSmallest(values);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1756, "18th century")]
        [InlineData(1555, "16th century")]
        [InlineData(1000, "10th century")]
        [InlineData(1001, "11th century")]
        [InlineData(2005, "21st century")]
        public void ReturnCentury(int year, string expected)
        {
            // Arrange

            // Actual
            var actual = Easy.Century(year);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 }, 11)]
        [InlineData(new int[] { 14, 13, 7, 1, 4, 12, 3, 7, 7, 12, 11, 5, 7 }, 4)]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5, 5, 6, 8, 8, 9, 10, 11, 13, 13, 14 }, 2)]
        [InlineData(new int[] { 21, 28, 0, 5, 11, 6, 17, 25, 2, 19 }, 6)]
        [InlineData(new int[] { 8, 11, 24, 2, 7, 4, 4, 25, 24, 14, 8, 0, 7 }, 10)]
        [InlineData(new int[] { 26, 17, 4, 25, 29, 26, 8, 30, 4, 20, 2, 7, 29, 7, 20, 30, 23, 5 }, 9)]
        public void ReturnLargestGap(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Easy.LargestGap(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 3.1)]
        [InlineData(2, 3.14)]
        [InlineData(3, 3.142)]
        [InlineData(4, 3.1416)]
        public void ReturnMyPi(int n, decimal expected)
        {
            // Arrange

            // Actual
            var actual = Easy.MyPi(n);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(23, false)]
        [InlineData(9562, false)]
        [InlineData(10019, false)]
        [InlineData(1, true)]
        [InlineData(3223, true)]
        public void ReturnIsSymmetrical(int num, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.IsSymmetrical(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, true)]
        [InlineData(28, true)]
        [InlineData(496, true)]
        [InlineData(8128, true)]
        [InlineData(33550336, true)]
        public void ReturnCheckPerfect(int num, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.CheckPerfect(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("The quick brown fox!", "The quick brown fox")]
        [InlineData("%fd76$fd(-)6GvKlO.", "fd76fd-6GvKlO")]
        [InlineData("D0n$c sed 0di0 du1", "D0nc sed 0di0 du1")]
        [InlineData("cat_pic.jpeg", "cat_picjpeg")]
        [InlineData("519-555-8093", "519-555-8093")]
        [InlineData("h-d+=rf[]_{}<>.,`~!@#$%^&*(|)", "h-drf_")]
        public void ReturnRemoveSpecialCharacters(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Easy.RemoveSpecialCharacters(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("I am Ne mo Nemo !", "I found Nemo at 5!")]
        [InlineData("N e m o is NEMO NeMo Nemo !", "I found Nemo at 8!")]
        [InlineData("I am Nemo's dad Nemo senior .", "I found Nemo at 5!")]
        [InlineData("Oh, hello !", "I can't find Nemo :(")]
        [InlineData("Is it Nemos, Nemona, Nemoor or Garfield?", "I can't find Nemo :(")]
        [InlineData("Nemo is a clown fish, he has white and orange stripes. Nemo , come back!", "I found Nemo at 1!")]
        public void ReturnFindNemo(string sentence, string expected)
        {
            // Arrange

            // Actual
            var actual = Easy.FindNemo(sentence: sentence);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 19, 5, 42, 2, 77 }, 7)]
        [InlineData(new int[] { 10, 343445353, 3453445, 345354534 }, 3453455)]
        [InlineData(new int[] { 2, 9, 6, -1 }, 8)]
        [InlineData(new int[] { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 }, 563)]
        [InlineData(new int[] { 3683, 2902, 3951, -475, 1617, -2385 }, 4519)]
        public void ReturnSumSmallest(int[] values, int expected)
        {
            // Arrange

            // Actual
            var actual = Easy.SumSmallest(values);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(31, true)]
        [InlineData(18, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        [InlineData(1, false)]
        [InlineData(3, true)]
        [InlineData(48, false)]
        [InlineData(10, false)]
        public void isPrime(int x, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.isPrime(x);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ratio", "orator", true)]
        [InlineData("sparkling", "groups", true)]
        [InlineData("mentee", "eminem", true)]
        [InlineData("yahtzee", "easy", true)]
        [InlineData("bush", "hubris", false)]
        [InlineData("edit", "cheese", false)]
        [InlineData("false", "true", false)]
        [InlineData("cupid", "dionysus", false)]
        [InlineData("futile", "elephant", false)]
        [InlineData("", "", true)]
        [InlineData("", "abc", false)]
        [InlineData("a", "a", true)]
        [InlineData("a", "b", false)]
        [InlineData("&!", "!&", true)]
        [InlineData("5556", "65", true)]
        public void ReturnIsStrangePair(string str1, string str2, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.IsStrangePair(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2020, true)]
        [InlineData(10, 2017, true)]
        [InlineData(1, 1985, false)]
        [InlineData(5, 1619, false)]
        public void ReturnHasFriday13th(int month, int year, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.HasFriday13th(month, year);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(123, 321)]
        [InlineData(670276097, 977766200)]
        [InlineData(2619805, 9865210)]
        [InlineData(81294, 98421)]
        [InlineData(0, 0)]
        public void ReturnSortDescending(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Easy.SortDescending(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Algorism", true)]
        [InlineData("PasSword", false)]
        public void IsIsogram(string str, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.IsIsogram(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(838, true)]
        [InlineData(77, true)]
        [InlineData(95159, true)]
        [InlineData(839, false)]
        [InlineData(4234, false)]
        [InlineData(13, false)]
        public void IsPalindrome(int num, bool expected)
        {
            // Arrange

            // Actual
            var actual = Easy.IsPalindrome(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(3, 10)]
        [InlineData(4, 20)]
        [InlineData(5, 35)]
        [InlineData(9, 165)]
        public void Tetra(int n, int expected)
        {
            // Arrange

            // Act
            var actual = Easy.Tetra(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, "a", "b" }, new int[] { 1, 2 })]
        [InlineData(new object[] { 1, "a", "b", 0, 15 }, new int[] { 1, 0, 15 })]
        [InlineData(new object[] { 1, 2, "aasf", "1", "123", 123 }, new int[] { 1, 2, 123 })]
        public void ReturnFilterArray(object[] arr, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Easy.FilterArray(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1000, "1,000")]
        [InlineData(1000000, "1,000,000")]
        [InlineData(20, "20")]
        [InlineData(0, "0")]
        [InlineData(12948, "12,948")]
        public void FormatNum(int num, string expected)
        {
            // Arrange

            // Actual
            var actual = Easy.FormatNum(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6", "542 -214")]
        [InlineData("1 -1", "1 -1")]
        [InlineData("-1 -1", "-1 -1")]
        [InlineData("1 -1 0", "1 -1")]
        [InlineData("1 1 0", "1 0")]
        [InlineData("-1 -1 0", "0 -1")]
        [InlineData("42", "42 42")]
        [InlineData("1 1", "1 1")]
        public void ReturnHighLow(string str, string expected)
        {
            // Arrange

            // Act
            var actual = Easy.HighLow(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(32, 8, 8)]
        [InlineData(8, 12, 4)]
        [InlineData(17, 13, 1)]
        [InlineData(14, 7, 7)]
        [InlineData(32, 16, 16)]
        public void ReturnGCD(int n1, int n2, int expected)
        {
            // Arrange

            // Actual
            var actual = Easy.gcd(n1, n2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4556364607935616", "############5616")]
        [InlineData("64607935616", "#######5616")]
        [InlineData("1", "1")]
        [InlineData("", "")]
        [InlineData("tBy>L/cMe+?<j:6n;C~H", "################;C~H")]
        public void ReturnMaskify(string str, string expected)
        {
            // Arrange

            // Act
            var actual = Easy.Maskify(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("lorem ipsum", "LEREM EPSEM")]
        [InlineData("Leeroy jenkins!", "LEEREY JENKENS!")]
        [InlineData(
            "A, wonderful, day, don't, you, think?",
            "E, WENDERFEL, DEY, DEN'T, YEE, THENK?"
        )]
        [InlineData("Hello world", "HELLE WERLD")]
        [InlineData("start queueing you oafs", "STERT QEEEEENG YEE EEFS")]
        public void ReturnToScottishScreaming(string str, string expected)
        {
            // Arrange

            // Act
            var actual = Easy.ToScottishScreaming(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("test", "es")]
        [InlineData("testing", "t")]
        [InlineData("middle", "dd")]
        [InlineData("A", "A")]
        [InlineData("inhabitant", "bi")]
        public void ReturnGetMiddle(string str, string expected)
        {
            // Arrange

            // Act
            var actual = Easy.GetMiddle(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1/2", false)]
        [InlineData("7/4", true)]
        [InlineData("10/10", false)]
        [InlineData("12/30", false)]
        [InlineData("28/3", true)]
        [InlineData("35/31", true)]
        public void ReturnGreaterThanOne(string str, bool expected)
        {
            // Arrange

            // Act
            var actual = Easy.GreaterThanOne(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1234", true)]
        [InlineData("12345", false)]
        [InlineData("a234", false)]
        [InlineData("", false)]
        [InlineData("%234", false)]
        [InlineData("`234", false)]
        [InlineData("@234", false)]
        public void ValidatePIN(string pin, bool expected)
        {
            // Arrange

            // Act
            var actual = Easy.ValidatePIN(pin);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 },
            new int[] { 10, -65 }
        )]
        [InlineData(
            new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 },
            new int[] { 7, -252 }
        )]
        [InlineData(new double[] { 91, -4, 80, -73, -28 }, new int[] { 2, -105 })]
        public void ReturnCountPosSumNeg(double[] arr, int[] expected)
        {
            // Arrange

            // Act
            var actual = Easy.CountPosSumNeg(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 2)]
        [InlineData(0, 0)]
        [InlineData(100, 3)]
        [InlineData(101, 4)]
        [InlineData(999, 8)]
        [InlineData(123456789, 16)]
        [InlineData(1234567890, 12)]
        public void ReturnCountOnes(int i, int expected)
        {
            // Arrange

            // Act
            var actual = Easy.CountOnes(i);

            // Arrange
            Assert.Equal(expected, actual);
        }

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
            var actual = Easy.ount_all(txt);

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
