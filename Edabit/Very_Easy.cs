using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Very_Easy
    {
        public static int FindLargestNum(int[] arr)
        {
            return arr.Max();
        }

        public static double FindSmallestNum(double[] arr)
        {
            return arr.Min();
        }

        public static int toInt(string str)
        {
            return Int32.Parse(str);
        }

        public static string toStr(int num)
        {
            return num.ToString();
        }

        public static string Operation(int num1, int num2)
        {
            if (num1 + num2 == 24)
                return "added";
            if (num1 - num2 == 24)
                return "subtracted";
            if (num1 / num2 == 24)
                return "divided";
            if (num1 * num2 == 24)
                return "multiplied";
            return "none";
        }

        public static bool IsPlural(string word)
        {
            return word.Last() == 's';
        }

        public static object GetLastItem(object[] arr)
        {
            return arr.Last();
        }

        public static bool EqualSlices(int total, int people, int each)
        {
            return people == 0 ? true : (total / people) == each;
        }

        public static int CharToASCII(char ch)
        {
            return (int)ch;
        }

        public static int Length(int n)
        {
            return $"{n}".Length;
        }

        public static bool Both(int n1, int n2)
        {
            if (n1 < 0 && n2 < 0)
                return true;
            if (n1 > 0 && n2 > 0)
                return true;
            if (n1 == 0 && n2 == 0)
                return true;
            return false;
        }

        public static int Length(string str)
        {
            if (str == "")
                return 0;
            return 1 + Length(str.Substring(1));
        }

        public static bool HasSpaces(string str)
        {
            return str.Contains(" ");
        }

        public static int StringInt(string txt)
        {
            return Int32.Parse(txt);
        }

        public static bool IsSafeBridge(string str)
        {
            return !str.Contains(" ");
        }

        public static bool ShouldServeDrinks(int age, bool on_break)
        {
            return age >= 18 && !on_break;
        }

        public static int Diff(int[] arr)
        {
            return arr.Max() - arr.Min();
        }

        public static bool isEmpty(string str)
        {
            return String.IsNullOrEmpty(str);
        }

        public static int TotalCups(int n)
        {
            return n + (n / 6);
        }

        public static List<int> PrintArray(int number)
        {
            List<int> array = new List<int>();

            for (int counter = 1; counter <= number; counter++)
            {
                array.Add(counter);
            }

            return array;
        }

        public static int StackBoxes(int n)
        {
            return n * n;
            ;
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
            if (h <= 0 || w <= 0)
                return -1;
            return h * w;
        }
    }
}
