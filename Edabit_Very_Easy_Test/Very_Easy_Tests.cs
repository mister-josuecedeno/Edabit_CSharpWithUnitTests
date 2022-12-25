using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Edabit;

namespace Edabit.Tests
{
    
    public class Very_Easy_Tests
    {
        [Theory]
        [InlineData("37", 37)]
        [InlineData("113", 113)]
        [InlineData("5", 5)]
        [InlineData("5231", 5231)]
        public void ReturnToInt(string str, int expected) { 
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
        public void ReturnToStr(int num, string expected) { 
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
        public void ReturnIsPlural (string word, bool expected)
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
        [InlineData(new object[] { null }, null)]
        [InlineData(new object[] { false }, false)]
        [InlineData(new object[] { null, null, null }, null)]
        [InlineData(new object[] { 1, 2, 3, 56, 87, 23, 65, 45 }, 45)]
        [InlineData(new object[] { "Apple", "Orange", null }, null)]
        [InlineData(new object[] { true, false, "Apple" }, "Apple")]
        [InlineData(new object[] { 1 }, 1)]
        public void ReturnLastItem (object[] arr, object expected)
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
        public void ReturnEqualSlices (int total, int people, int each, bool expected)
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
        public void ReturnCharToASCII (char ch, int expected)
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
        public void ReturnNumberLength (int n, int expected)
        {
            // Arrange

            // Act
            int actual = Very_Easy.Length (n);  

            // Assert
            Assert.Equal (expected, actual);
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
        public void BothShouldReturnTrueIfBothMatchCriteria (int n1, int n2, bool expected)
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
        public void Length_ReturnLengthOfString (string str, int expected)
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
        public void ShouldServeDrinks_ReturnIfShouldServeDrinks(int age, bool on_break, bool expected)
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
        public void PrintArray_ReturnArrayNumbered1ToN (int n, int[] expected)
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
        public void StackBoxes_ReturnTheSquareOfN (int n, int expected)
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
        public void ConcatName_ReturnStringsConcatenated(string firstName, string lastName, string expected)
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
        public void IsOdd_ReturnTrueIfNumberIsOdd (int num, bool expected)
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
        public void Comp_ReturnTrueIfLengthsMatch (string str1, string str2, bool expected)
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
