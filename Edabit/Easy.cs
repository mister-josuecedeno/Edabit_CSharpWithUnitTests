using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Easy
    {
        // https://edabit.com/challenge/zcuASzWmpFHpPtrbH
        public static string HighLow(string str)
        {
            return string.Empty;
        }

        // https://edabit.com/challenge/b5HL5ju3Fpx5zjoXn
        public static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }

            return gcd(n2, n1 % n2);
        }

        // https://edabit.com/challenge/RFeBL2TzSf7mRMNJi
        public static string Maskify(string str)
        {
            if(str.Length <= 4)
            {
                return str;
            }
            
            string mask = new string('#', str.Length - 4);
            string lastFour = str.Substring(str.Length - 4);
            return mask + lastFour;
        }

        public static string ToScottishScreaming(string str)
        {
            string pattern = @"[aiouAIOU]";
            string replaceVowels = Regex.Replace(str, pattern, "E");
            return replaceVowels.ToUpper();
        }

        // https://edabit.com/challenge/JF25KTZEcPzXhBvpM
        public static string GetMiddle(string str)
        {
            int middle = (int)str.Length / 2;
            if(str.Length % 2 == 0) {  return str.Substring(middle - 1, 2); }

            return str.Substring(middle, 1);
        }

        // https://edabit.com/challenge/uCtG3Gtfx7fgNWM58
        public static bool GreaterThanOne(string str)
        {
            string[] numbers = str.Split('/');
            return int.Parse(numbers[0]) > int.Parse(numbers[1]);
        }

        // https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD
        public static bool ValidatePIN(string pin)
        {
            string pattern = @"^\d{4}(\d{2})?$";
            return Regex.IsMatch(pin, pattern);
        }

        // https://edabit.com/challenge/SXeEZPxDM9Y5HzLvw
        public static int[] CountPosSumNeg(double[] arr)
        {
            int count = arr.Count(n => n > 0);
            int sum = (int)arr.Where(n => n < 0).Sum();
            return [count, sum];
        }

        // https://edabit.com/challenge/zn3A3AAzoE7vezw7Q
        public static int CountOnes(int i)
        {
            string binaryString = Convert.ToString(i, 2);
            string numberPattern = @"[1]";
            Regex regexNumbers = new Regex(numberPattern);
            return regexNumbers.Matches(binaryString).Count;
        }

        // https://edabit.com/challenge/ZSvj2W3J6QRydkyh2
        public static string ount_all(string txt)
        {
            string letterPattern = @"[a-zA-Z]";
            Regex regexLetters = new Regex(letterPattern);

            string numberPattern = @"[0-9]";
            Regex regexNumbers = new Regex(numberPattern);

            int letters = regexLetters.Matches(txt).Count;
            int digits = regexNumbers.Matches(txt).Count;

            return $"{{ LETTERS = {letters}, DIGITS = {digits} }}";
        }

        // https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
        public static int[] IndexOfCapitals(string str)
        {
            List<int> list = new List<int>();
            int index = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    list.Add(index);
                }
                index++;
            }

            return list.ToArray();

            // Alternative
            //return str
            //    .Select((c, i) => (c, i))
            //    .Where(t => char.IsUpper(t.c))
            //    .Select(t => t.i)
            //    .ToArray();
        }

        // https://edabit.com/challenge/MMRWB6cYnpsp3uTPT
        public static double[] CumulativeSum(double[] arr)
        {
            double sum = 0;
            double[] cumulativeSum = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                cumulativeSum[i] = sum;
            }

            return cumulativeSum;
        }

        // https://edabit.com/challenge/DYNxn8fpWHutWZxEZ
        public static double Magnitude(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;

            return Math.Sqrt(arr.Select(n => n * n).Sum());
        }

        // https://edabit.com/challenge/moqcQ563NukBBbKDL
        public static string LettersOnly(string str)
        {
            string pattern = @"[^a-zA-Z]";
            return Regex.Replace(str, pattern, "");
        }

        // https://edabit.com/challenge/9Emx6unF8evWiXnJA
        public static double[] UniqueSort(double[] arr)
        {
            return arr.Distinct().OrderBy(n => n).ToArray();
        }

        // https://edabit.com/challenge/xvSXDZh2GHE6F28SA
        public static bool IsValid(string zip)
        {
            string pattern = @"^\d{5}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(zip);
        }
    }
}
