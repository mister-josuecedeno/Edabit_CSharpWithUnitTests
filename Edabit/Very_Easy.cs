﻿using System.Text;
using System.Text.RegularExpressions;

namespace Edabit
{
    public static class Very_Easy
    {
        public static string RemoveFirstLast(string str)
        {
            if (str.Length < 3)
            {
                return str;
            }

            return str.Substring(1, str.Length - 2);
        }

        public static string Repetition(string txt, int n)
        {
            if (n <= 0)
                return string.Empty;

            if (n == 1)
                return txt;

            return txt + Repetition(txt, n - 1);
        }

        public static int Sum(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += i;
            }

            return result;
        }

        public static int CountDs(string str)
        {
            Regex regex = new Regex("d", RegexOptions.IgnoreCase);
            var matches = regex.Matches(str);
            return matches.Count;
        }

        public static string LongBurp(int b)
        {
            var repeat = new string('r', b);
            return $"Bu{repeat}p";
        }

        public static int CountClaps(string txt)
        {
            Regex regex = new Regex("C");
            var matches = regex.Matches(txt);
            return matches.Count;
        }

        public static bool HurdleJump(int[] hurdles, int jumpHeight)
        {
            return hurdles.All(h => h <= jumpHeight);
        }

        public static bool BackToHome(string d)
        {
            Dictionary<char, int> direction = new Dictionary<char, int>();
            direction['N'] = 2;
            direction['S'] = -2;
            direction['W'] = 1;
            direction['E'] = -1;

            var total = 0;

            foreach (var letter in d)
            {
                total += direction[letter];
            }

            return total == 0;
        }

        public static int NumberSyllables(string word)
        {
            return word.Split('-').Length;
        }

        public static int Days(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public static int CountWords(string str)
        {
            string pattern = @"[\w']+";
            MatchCollection matches = Regex.Matches(str, pattern);
            return matches.Count;
        }

        public static int FindIndex(string[] arr, string str)
        {
            // Alternative
            // return Array.IndexOf(arr, str);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(str))
                {
                    return i;
                }
            }

            return -1;
        }

        public static string Go(int num)
        {
            StringBuilder sb = new StringBuilder(num);

            for (int i = 0; i < num; i++)
            {
                sb.Append('-');
            }

            return sb.ToString();
        }

        public static string GetCase(string str)
        {
            string letters = Regex.Replace(str, @"[^a-zA-Z]+", "");
            bool allUpper = letters.All(c => char.IsUpper(c));
            bool allLower = letters.All(c => char.IsLower(c));

            if (allUpper)
            {
                return "upper";
            }

            if (allLower)
            {
                return "lower";
            }

            return "mixed";
        }

        public static int NumArgs(params object[] p)
        {
            return p.Length;
        }

        public static double YenToUsd(int yen)
        {
            return Math.Round(yen / 107.5, 2);
        }

        public static int CountTrue(bool[] arr)
        {
            return arr.Where(b => b).Count();
        }

        public static int CubesSum(int[] nums_arr)
        {
            var total = 0;

            for (int i = 0; i < nums_arr.Length; i++)
            {
                total += Convert.ToInt32(Math.Pow(nums_arr[i], 3));
            }

            return total;
        }

        public static int[] ConcatArrays(int[] arr1, int[] arr2)
        {
            return arr1.Concat(arr2).ToArray();
        }

        public static string Edaabit(int n)
        {
            if (n < 0)
            {
                return "";
            }

            var repeat = new string('a', n);
            return $"Ed{repeat}bit";
        }

        public static double SmashFactor(double ballSpeed, double clubSpeed)
        {
            return Math.Round(ballSpeed / clubSpeed, 2);
        }

        public static int AddUp(int num)
        {
            var total = 0;

            for (var i = 1; i <= num; i++)
            {
                total += i;
            }

            return total;
        }

        public static int Flip(int y)
        {
            return Convert.ToInt32(y == 0);
        }

        public static string Wumbo(string words)
        {
            return words.Replace("M", "W");
        }

        public static object[] FirstLastAgain(object[] values)
        {
            var first = values[0];
            var last = values[values.Length - 1];
            return new object[] { first, last };
        }

        public static bool Check(int[] arr, int el)
        {
            return arr.Contains(el);
        }

        public static string MissingAngle(int angle1, int angle2)
        {
            int angle3 = 180 - (angle1 + angle2);
            if (angle3 < 90)
                return "acute";
            if (angle3 > 90)
                return "obtuse";
            if (angle3 == 90)
                return "right";
            return "error";
        }

        public static int FindDigitAmount(int num)
        {
            var str = num.ToString();
            return str.Length;
        }

        public static string SeriesResistance(double[] arr)
        {
            var total = arr.Sum();
            var suffix = total <= 1 ? " ohm" : " ohms";
            return total + suffix;
        }

        public static string[] AddEnding(string[] arr, string ending)
        {
            return arr.Select(x => x + ending).ToArray();
        }

        public static string AmazingEdabit(string str)
        {
            if (str.Contains("edabit"))
            {
                return str;
            }

            return str.Replace("amazing", "not amazing");
        }

        public static int[] Reverse(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        public static int Search(int[] arr, int item)
        {
            return Array.IndexOf(arr, item);
        }

        public static int PosCom(int n)
        {
            return (int)Math.Pow(2, n);
        }

        public static bool CheckEnding(string str1, string str2)
        {
            return str1.EndsWith(str2);
        }

        public static string FirstLast(string str)
        {
            var first = str[0];
            var last = str[str.Length - 1];
            return first.ToString() + last.ToString();
        }

        public static int differenceMaxMin(int[] arr)
        {
            return arr.Max() - arr.Min();
        }

        public static bool match(string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
        }

        public static int Calculate(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                case "%":
                    return num1 % num2;
                default:
                    return 0;
            }
        }

        public static int Mod(int a, int b)
        {
            return a - (b * Convert.ToInt32(a / b));
        }

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
