using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit.Sdk;

namespace Edabit.Tests
{
    public class Very_Easy_Tests
    {
        [Theory]
        [InlineData(4, 10)]
        [InlineData(13, 91)]
        [InlineData(600, 180300)]
        [InlineData(392, 77028)]
        [InlineData(53, 1431)]
        [InlineData(897, 402753)]
        [InlineData(23, 276)]
        [InlineData(1000, 500500)]
        [InlineData(738, 272691)]
        [InlineData(100, 5050)]
        [InlineData(925, 428275)]
        [InlineData(1, 1)]
        [InlineData(999, 499500)]
        [InlineData(175, 15400)]
        [InlineData(111, 6216)]
        public void ReturnAddUp(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.AddUp(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void ReturnFlip(int y, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Flip(y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("WHAT DO YOU MEAN WE'RE OUT OF MONEY", "WHAT DO YOU WEAN WE'RE OUT OF WONEY")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLWNOPQRSTUVWXYZ")]
        [InlineData("1 WUMBO 2 WUMBO 3 WUMBO 4", "1 WUWBO 2 WUWBO 3 WUWBO 4")]
        public void ReturnWumbo(string words, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Wumbo(words);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFirstLastAgain()
        {
            // Arrange

            // Actual

            // Assert
            Assert.Equal(
                new object[] { 5, 25 },
                Very_Easy.FirstLastAgain(new object[] { 5, 10, 15, 20, 25 })
            );
            Assert.Equal(
                new object[] { "edabit", true },
                Very_Easy.FirstLastAgain(new object[] { "edabit", 13, null, false, true })
            );
            Assert.Equal(
                new object[] { "", null },
                Very_Easy.FirstLastAgain(new object[] { "", 4, "6", "hello", null })
            );
            Assert.Equal(
                new object[] { "hello", "com" },
                Very_Easy.FirstLastAgain(new object[] { "hello", "edabit", "dot", "com" })
            );
            Assert.Equal(new object[] { 3, 1 }, Very_Easy.FirstLastAgain(new object[] { 3, 2, 1 }));
            Assert.Equal(
                new object[] { "one", "two" },
                Very_Easy.FirstLastAgain(new object[] { "one", "two" })
            );
            Assert.Equal(
                new object[] { false, false },
                Very_Easy.FirstLastAgain(
                    new object[] { false, false, true, false, false, true, false }
                )
            );
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, true)]
        [InlineData(new int[] { 1, 1, 2, 1, 1 }, 3, false)]
        [InlineData(new int[] { 1, 1, 2, 1, 5, 4, 7 }, 7, true)]
        [InlineData(new int[] { 1, 1, 2, 1, 5, 4, 7 }, 8, false)]
        [InlineData(new int[] { 5, 5, 5, 6 }, 5, true)]
        [InlineData(new int[0], 5, false)]
        public void ReturnCheck(int[] arr, int el, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Check(arr, el);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(27, 59, "obtuse")]
        [InlineData(135, 11, "acute")]
        [InlineData(45, 45, "right")]
        [InlineData(45, 15, "obtuse")]
        [InlineData(31, 100, "acute")]
        [InlineData(35, 55, "right")]
        public void ReturnMissingAngle(int angle1, int angle2, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.MissingAngle(angle1, angle2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(67, 2)]
        [InlineData(123, 3)]
        [InlineData(55551, 5)]
        [InlineData(96456431, 8)]
        [InlineData(0, 1)]
        public void ReturnFindDigitAmount(int num, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindDigitAmount(num);

            // Asseert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 1, 5, 6, 3 }, "15 ohms")]
        [InlineData(new double[] { 0.2, 0.3, 0.4 }, "0.9 ohm")]
        [InlineData(new double[] { 10, 12, 1, 10 }, "33 ohms")]
        [InlineData(new double[] { 10, 13, 3.8, 20, 10 }, "56.8 ohms")]
        [InlineData(new double[] { 0.5, 0.5 }, "1 ohm")]
        [InlineData(new double[] { 16, 30, 22.8, 4 }, "72.8 ohms")]
        [InlineData(new double[] { 20, 15, 32.5, 2 }, "69.5 ohms")]
        [InlineData(new double[] { 52, 22, 20, 30 }, "124 ohms")]
        [InlineData(new double[] { 10, 12, 32, 4.9, 5, 6, 71 }, "140.9 ohms")]
        public void ReturnSeriesResistance(double[] arr, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.SeriesResistance(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new string[] { "clever", "meek", "hurried", "nice" },
            "ly",
            new string[] { "cleverly", "meekly", "hurriedly", "nicely" }
        )]
        [InlineData(
            new string[] { "new", "pander", "scoop" },
            "er",
            new string[] { "newer", "panderer", "scooper" }
        )]
        [InlineData(
            new string[] { "bend", "sharpen", "mean" },
            "ing",
            new string[] { "bending", "sharpening", "meaning" }
        )]
        [InlineData(
            new string[] { "bend", "tooth", "mint" },
            "y",
            new string[] { "bendy", "toothy", "minty" }
        )]
        [InlineData(
            new string[] { "bend", "tooth", "mint" },
            "ier",
            new string[] { "bendier", "toothier", "mintier" }
        )]
        public void ReturnAddEnding(string[] arr, string ending, string[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.AddEnding(arr, ending);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("edabit is amazing.", "edabit is amazing.")]
        [InlineData("Mubashir is amazing.", "Mubashir is not amazing.")]
        [InlineData("Trump is amazing.", "Trump is not amazing.")]
        [InlineData("Infinity is amazing.", "Infinity is not amazing.")]
        [InlineData("Mubashir and edabit are amazing.", "Mubashir and edabit are amazing.")]
        [InlineData("Matt is amazing.", "Matt is not amazing.")]
        [InlineData("Helen is amazing.", "Helen is not amazing.")]
        [InlineData("Python and edabit are amazing.", "Python and edabit are amazing.")]
        [InlineData("C++ is amazing.", "C++ is not amazing.")]
        [InlineData("javascript is amazing.", "javascript is not amazing.")]
        [InlineData("java is amazing.", "java is not amazing.")]
        [InlineData("ruby is amazing.", "ruby is not amazing.")]
        [InlineData("SQL is amazing.", "SQL is not amazing.")]
        [InlineData("CSS is amazing.", "CSS is not amazing.")]
        [InlineData("Pakistan is amazing. edabit", "Pakistan is amazing. edabit")]
        [InlineData("You and edabit are amazing.", "You and edabit are amazing.")]
        [InlineData("Matt and edabit are amazing.", "Matt and edabit are amazing.")]
        [InlineData("Helen and edabit are amazing.", "Helen and edabit are amazing.")]
        [InlineData("Everyone is amazing.", "Everyone is not amazing.")]
        [InlineData("Swift and edabit are amazing.", "Swift and edabit are amazing.")]
        public void ReturnAmazingEdabit(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.AmazingEdabit(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [InlineData(new int[] { 5, 6, 7 }, new int[] { 7, 6, 5 })]
        [InlineData(new int[] { 9, 9, 2, 3, 4 }, new int[] { 4, 3, 2, 9, 9 })]
        [InlineData(new int[] { 3, 3 }, new[] { 3, 3 })]
        [InlineData(new int[] { -1, -1, -1 }, new int[] { -1, -1, -1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void ReturnReverse(int[] arr, int[] expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Reverse(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 3 }, 5, 1)]
        [InlineData(new int[] { 9, 8, 3 }, 3, 2)]
        [InlineData(new int[] { 1, 2, 3 }, 4, -1)]
        [InlineData(new int[] { 1, 5, 3, 10, 17, 20, -6 }, 20, 5)]
        public void ReturnSearch(int[] arr, int item, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Search(arr, item);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 32)]
        [InlineData(4, 16)]
        [InlineData(3, 8)]
        [InlineData(2, 4)]
        [InlineData(1, 2)]
        [InlineData(6, 64)]
        [InlineData(7, 128)]
        [InlineData(8, 256)]
        [InlineData(9, 512)]
        [InlineData(10, 1024)]
        [InlineData(25, 33554432)]
        public void ReturnPosCom(int n, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.PosCom(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", "bc", true)]
        [InlineData("abc", "d", false)]
        [InlineData("samurai", "zi", false)]
        [InlineData("feminine", "nine", true)]
        [InlineData("convention", "tio", false)]
        [InlineData("cooperative", "ooper", false)]
        [InlineData("extraterrestrial", "xtraterrestrial", true)]
        [InlineData("access", "ss", true)]
        [InlineData("motorist", "is", false)]
        [InlineData("landowner", "landowner", true)]
        public void ReturnCheckEnding(string str1, string str2, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.CheckEnding(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("forza", "fa")]
        [InlineData("kali", "ki")]
        [InlineData("always", "as")]
        [InlineData("love", "le")]
        [InlineData("supernatural", "sl")]
        [InlineData("edabit", "et")]
        public void ReturnFirstLast(string str, string expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FirstLast(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 10, 4, 1, 2, 8, 91 }, 90)]
        [InlineData(new int[] { -70, 43, 34, 54, 22 }, 124)]
        public void ReturnDifferenceMaxMin(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.differenceMaxMin(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", "hELLo", true)]
        [InlineData("hey", "hey", true)]
        [InlineData("venom", "VENOM", true)]
        [InlineData("maGIciAN", "magician", true)]
        [InlineData("stupIFy", "stupifY", true)]
        [InlineData("bald", "blad", false)]
        [InlineData("motive", "emotive", false)]
        [InlineData("mask", "mAskinG", false)]
        [InlineData("skim", "skimp", false)]
        [InlineData("EXCEl", "exceLs", false)]
        public void ReturnIsMatch(string s1, string s2, bool expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.match(s1, s2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24, 100, "-", -76)]
        [InlineData(-20, -30, "+", -50)]
        [InlineData(38, 3, "*", 114)]
        [InlineData(49, 5, "%", 4)]
        [InlineData(1500, 5, "/", 300)]
        public void ReturnCalculate(int num1, int num2, string operation, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Calculate(num1, num2, operation);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, 0)]
        [InlineData(1, 3, 1)]
        [InlineData(5, 3, 2)]
        [InlineData(4, 5, 4)]
        [InlineData(218, 5, 3)]
        public void ReturnMod(int a, int b, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.Mod(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 5, 1, 3 }, 5)]
        [InlineData(new int[] { 13, 27, 18, 26 }, 27)]
        [InlineData(new int[] { 32, 35, 37, 39 }, 39)]
        [InlineData(new int[] { 1000, 1001, 857, 1 }, 1001)]
        [InlineData(new int[] { 27364, 837363, 736736, 73635 }, 837363)]
        [InlineData(new int[] { 30, 2, 40, 3 }, 40)]
        [InlineData(new int[] { 0, 1, 0, 0, 1 }, 1)]
        public void ReturnFindLargestNum(int[] arr, int expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindLargestNum(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 34, 15, 88, 2 }, 2)]
        [InlineData(new double[] { 34, -345, -1, 100 }, -345)]
        [InlineData(new double[] { -76, 1.345, 1, 0 }, -76)]
        [InlineData(new double[] { 0.4356, 0.8795, 0.5435, -0.9999 }, -0.9999)]
        [InlineData(new double[] { 7, 7, 7 }, 7)]
        [InlineData(new double[] { 4, 6, 1, 3, 4, 5, 5, 1 }, 1)]
        [InlineData(new double[] { -4, -6, -8, -1 }, -8)]
        [InlineData(new double[] { 54, 76, 23, 54 }, 23)]
        [InlineData(new double[] { 100 }, 100)]
        [InlineData(new double[] { 0, 1, 2, 3, 4, 5 }, 0)]
        public void ReturnFindSmallestNum(double[] arr, double expected)
        {
            // Arrange

            // Actual
            var actual = Very_Easy.FindSmallestNum(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("37", 37)]
        [InlineData("113", 113)]
        [InlineData("5", 5)]
        [InlineData("5231", 5231)]
        public void ReturnToInt(string str, int expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.toInt(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(37, "37")]
        [InlineData(113, "113")]
        [InlineData(5, "5")]
        [InlineData(5231, "5231")]
        public void ReturnToStr(int num, string expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.toStr(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 12, "added")]
        [InlineData(100, 76, "subtracted")]
        [InlineData(6, 4, "multiplied")]
        [InlineData(528, 22, "divided")]
        [InlineData(10, 12, "none")]
        public void ReturnOperation(int num1, int num2, string expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.Operation(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("dudes", true)]
        [InlineData("flowers", true)]
        [InlineData("checks", true)]
        [InlineData("varies", true)]
        [InlineData("efforts", true)]
        [InlineData("mood", false)]
        [InlineData("whiteboard", false)]
        [InlineData("cow", false)]
        [InlineData("word", false)]
        [InlineData("love", false)]
        public void ReturnIsPlural(string word, bool expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.IsPlural(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new object[] { "Cat", "Dog", "Duck" }, "Duck")]
        [InlineData(new object[] { 1, 2, 3 }, 3)]
        [InlineData(new object[] { null }, null)]
        [InlineData(new object[] { true, false, false, true }, true)]
        [InlineData(new object[] { 7, "String", false, null, null }, null)]
        [InlineData(new object[] { false }, false)]
        [InlineData(new object[] { null, null, null }, null)]
        [InlineData(new object[] { 1, 2, 3, 56, 87, 23, 65, 45 }, 45)]
        [InlineData(new object[] { "Apple", "Orange", null }, null)]
        [InlineData(new object[] { true, false, "Apple" }, "Apple")]
        [InlineData(new object[] { 1 }, 1)]
        public void ReturnLastItem(object[] arr, object expected)
        {
            // Arrange

            // Act
            var actual = Very_Easy.GetLastItem(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 3, 2, true)]
        [InlineData(8, 3, 3, false)]
        [InlineData(24, 12, 2, true)]
        [InlineData(5, 6, 1, false)]
        [InlineData(5, 0, 100, true)]
        [InlineData(15, 2, 7, true)]
        [InlineData(15, 2, 8, false)]
        public void ReturnEqualSlices(int total, int people, int each, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.EqualSlices(total, people, each);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('E', 69)]
        [InlineData('d', 100)]
        [InlineData('a', 97)]
        [InlineData('b', 98)]
        [InlineData('i', 105)]
        [InlineData('t', 116)]
        [InlineData('.', 46)]
        [InlineData(' ', 32)]
        [InlineData('1', 49)]
        public void ReturnCharToASCII(char ch, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.CharToASCII(ch);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 2)]
        [InlineData(6000, 4)]
        [InlineData(314, 3)]
        public void ReturnNumberLength(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Length(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, true)]
        [InlineData(-6, -9, true)]
        [InlineData(6, -2, false)]
        [InlineData(0, 0, true)]
        [InlineData(100, 1, true)]
        [InlineData(-80, -5000, true)]
        [InlineData(6, -999, false)]
        [InlineData(-1, 2, false)]
        [InlineData(0, 2, false)]
        public void BothShouldReturnTrueIfBothMatchCriteria(int n1, int n2, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.Both(n1, n2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apple", 5)]
        [InlineData("make", 4)]
        [InlineData("a", 1)]
        [InlineData("", 0)]
        public void Length_ReturnLengthOfString(string str, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Length(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Foo", false)]
        [InlineData("Foo bar", true)]
        [InlineData("Foo ", true)]
        [InlineData(" Foo", true)]
        [InlineData(" ", true)]
        [InlineData("", false)]
        [InlineData(",./;'[]-=", false)]
        public void HasSpaces_ReturnTrueIfContainsSpaces(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.HasSpaces(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("6", 6)]
        [InlineData("2", 2)]
        [InlineData("10", 10)]
        [InlineData("666", 666)]
        public void StringInt_TakesAStringAndReturnsAnInteger(string txt, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.StringInt(txt);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("####", true)]
        [InlineData("## ####", false)]
        [InlineData("#", true)]
        [InlineData("# #", false)]
        public void IsSafeBridge_ValidateIfBridgeIsSafe(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.IsSafeBridge(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(17, true, false)]
        [InlineData(30, true, false)]
        [InlineData(24, false, true)]
        [InlineData(18, false, true)]
        [InlineData(16, false, false)]
        [InlineData(18, true, false)]
        [InlineData(17, false, false)]
        public void ShouldServeDrinks_ReturnIfShouldServeDrinks(
            int age,
            bool on_break,
            bool expected
        )
        {
            // Arrange

            // Act
            bool actual = Very_Easy.ShouldServeDrinks(age, on_break);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -9, -8, 6, -9, 15, 6 }, 24)]
        [InlineData(new int[] { -5, 6, 18, 4, 16, -2 }, 23)]
        [InlineData(new int[] { -2, 20, -9, -9, -2, -7 }, 29)]
        [InlineData(new int[] { 4, -2, 11, -9, 15, 2 }, 24)]
        [InlineData(new int[] { 15, 10, 3, -6, 6, 19 }, 25)]
        [InlineData(new int[] { 1, 7, 18, -1, -2, 9 }, 20)]
        [InlineData(new int[] { 5, 1, -9, 7, -8, -10 }, 17)]
        [InlineData(new int[] { 4, 17, 12, 2, 10, 2 }, 15)]
        public void Diff(int[] arr, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Diff(arr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("            ", false)]
        [InlineData("38215", false)]
        [InlineData("afjabsdf", false)]
        [InlineData("!?@&", false)]
        public void isEmpty(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.isEmpty(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 7)]
        [InlineData(3, 3)]
        [InlineData(7, 8)]
        [InlineData(12, 14)]
        [InlineData(213, 248)]
        [InlineData(16, 18)]
        public void TotalCups(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.TotalCups(n);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(PrintArrayData))]
        public void PrintArray_ReturnArrayNumbered1ToN(int n, int[] expected)
        {
            // https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/

            // Arrange

            // Act
            List<int> actual = Very_Easy.PrintArray(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> PrintArrayData =>
            new List<object[]>
            {
                new object[] { 1, new int[] { 1 } },
                new object[] { 3, new int[] { 1, 2, 3 } },
                new object[] { 6, new int[] { 1, 2, 3, 4, 5, 6 } },
            };

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(0, 0)]
        [InlineData(5, 25)]
        [InlineData(27, 729)]
        [InlineData(196, 38416)]
        [InlineData(512, 262144)]
        public void StackBoxes_ReturnTheSquareOfN(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.StackBoxes(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Aiden", true)]
        [InlineData("Roxy", false)]
        [InlineData("Bert", false)]
        [InlineData("Dean", true)]
        [InlineData("Ian", true)]
        [InlineData("Brian", true)]
        [InlineData("Daniel", false)]
        public void isLastCharacterN_ChecksIfLastCharacterIsN(string word, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.isLastCharacterN(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apples", true)]
        [InlineData("banana", true)]
        [InlineData("cherry", true)]
        [InlineData("mango", false)]
        [InlineData("peach", false)]
        [InlineData("pears", false)]
        public void oddOrEven_ReturnEvenOrOddBasedOnLength(string word, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.oddOrEven(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "odd")]
        [InlineData(0, "even")]
        [InlineData(7, "odd")]
        [InlineData(12, "even")]
        [InlineData(6474, "even")]
        [InlineData(563, "odd")]
        [InlineData(301, "odd")]
        [InlineData(-3, "odd")]
        [InlineData(-7, "odd")]
        [InlineData(-12, "even")]
        [InlineData(-563, "odd")]
        [InlineData(-6474, "even")]
        [InlineData(-301, "odd")]
        public void IsEvenOrOdd_ReturnEvenOrOddAsString(int num, string expected)
        {
            // Arrange

            // Act
            string actual = Very_Easy.IsEvenOrOdd(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("John", "Doe", "Doe, John")]
        [InlineData("First", "Last", "Last, First")]
        [InlineData("A", "B", "B, A")]
        [InlineData(",", ",", ",, ,")]
        public void ConcatName_ReturnStringsConcatenated(
            string firstName,
            string lastName,
            string expected
        )
        {
            // Arrange

            // Act
            string actual = Very_Easy.ConcatName(firstName, lastName);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(100, 198)]
        [InlineData(1298734, 2597466)]
        public void NthEven_ReturnsTheNthEvenNumber(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.NthEven(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-3, 3)]
        [InlineData(250, 250)]
        [InlineData(0, 0)]
        [InlineData(6, 6)]
        [InlineData(1103, 1103)]
        public void Absolute_ReturnAnAbsoluteValueOfAValidNumber(int num, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.absolute(num);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-5, true)]
        [InlineData(-50, false)]
        [InlineData(0, false)]
        [InlineData(25, true)]
        [InlineData(-19, true)]
        [InlineData(12, false)]
        [InlineData(23, true)]
        [InlineData(-71, true)]
        public void IsOdd_ReturnTrueIfNumberIsOdd(int num, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.IsOdd(num);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("AB", "CD", true)]
        [InlineData("ABC", "DE", false)]
        [InlineData("hello", "edabit", false)]
        [InlineData("meow", "woof", true)]
        [InlineData("jrnvjrnnt", "cvjknfjvmfvnfjn", false)]
        [InlineData("jkvnjrt", "krnf", false)]
        [InlineData("Facebook", "Snapchat", true)]
        public void Comp_ReturnTrueIfLengthsMatch(string str1, string str2, bool expected)
        {
            // Arrange

            // Act
            bool actual = Very_Easy.Comp(str1, str2);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-4, -4)]
        [InlineData(212, -212)]
        [InlineData(-125, -125)]
        [InlineData(932123, -932123)]
        public void ReturnNegative_ValidNumberShouldConvertToNegative(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.ReturnNegative(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(8, 5, 40)]
        [InlineData(5, 4, 20)]
        [InlineData(2, 3, 6)]
        [InlineData(10000, 10000, 100000000)]
        [InlineData(-2, -5, -1)]
        [InlineData(0, 3, -1)]
        [InlineData(5, -3, -1)]
        [InlineData(0, 1, -1)]
        [InlineData(-1, 0, -1)]
        public void Area_SimpleValuesShouldCalculate(int h, int w, int expected)
        {
            // Arrange

            // Act
            double actual = Very_Easy.area(h, w);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
