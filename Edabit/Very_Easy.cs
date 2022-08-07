using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Very_Easy
    {
        public static int StackBoxes(int n)
        {
            return n * n; ;
        }

        public static bool isLastCharacterN(string word)
        {
            return word.EndsWith("n");
        }

        public static bool oddOrEven(string word)
        {
            return word.Length % 2 == 0;
        }

        public static string IsEvenOrOdd(int num)
        {
            return num % 2 == 0 ? "even" : "odd";
        }

        public static string ConcatName(string firstName, string lastName)
        {
            return $"{lastName}, {firstName}";
        }

        public static int NthEven(int n)
        {
            return (n - 1) * 2;
        }

        public static int absolute(int num)
        {
            return num < 0 ? -num : num;
        }

        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool Comp(string str1, string str2)
        {
            return str1.Length == str2.Length;
        }

        public static int ReturnNegative(int n)
        {
            return n < 0 ? n : n * -1;
        }

        public static int area(int h, int w)
        {
            if (h <= 0 || w <= 0) return -1;
            return h * w;
        }
    }
}
