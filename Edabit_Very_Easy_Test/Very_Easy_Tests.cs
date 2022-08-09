﻿using System;
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
