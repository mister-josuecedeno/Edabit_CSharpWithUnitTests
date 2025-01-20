using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Data;
using System.Linq.Expressions;

namespace Edabit
{
    public static class Medium
    {
        // https://edabit.com/challenge/8qkRcwf4ARtXpdwEW
        public static int MajorSum(int[] arr)
        {
            return -1;
        }

        // https://edabit.com/challenge/X6zTfuS9eZ4Ft6GLm
        public static int LetterDistance(string str1, string str2)
        {
            int minLength = Math.Min(str1.Length, str2.Length);
            int difference = Math.Abs(str1.Length - str2.Length);

            int totalDistance = 0;

            for (int i = 0; i < minLength; i++)
            {
                totalDistance += Math.Abs(str1[i] - str2[i]);
            }

            return totalDistance + difference;
        }

        // https://edabit.com/challenge/fS4Br5GgN3aT5mBxN
        public static string OddishOrEvenish(int num)
        {
            int sum = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 2 == 0)
            {
                return "Evenish";
            } else
            {
                return "Oddish";
            }
        }

        // https://edabit.com/challenge/gnmjJ9aomQJvzTR8N
        public static int GuessSequence(int num)
        {
            // Coefficients determined by solving the equations
            int A = 30;
            int B = 60;
            int C = 0;

            // Calculate the nth term
            return A * num * num + B * num + C;
        }

        // https://edabit.com/challenge/jJshPejQ5C44TPpSv
        public static int Equation(string s)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToInt32(table.Compute(s, System.String.Empty));
        }

        // https://edabit.com/challenge/mxDncdiseARvSJA5E
        public static string Reverse(string str)
        {
            string[] words = str.Split(' ');
            var result = words.Select(word =>
                word.Length >= 5
                    ? new string(word.Reverse().ToArray())
                    : word
            );

            return string.Join(" ", result);
        }

        // https://edabit.com/challenge/5tZQKkMhYPNxQxmnG
        public static bool IsPalindrome(string str)
        {
            Regex regex = new Regex("[a-z0-9]", RegexOptions.IgnoreCase);
            string match = string.Join("", regex.Matches(str).Cast<Match>().Select(m => m.Value)).ToLower();

            return match.SequenceEqual(match.Reverse());
        }

        // https://edabit.com/challenge/hmt8k8oq3a83QznjJ
        public static int NumberOfDays(int[] coordinates)
        {
            int travelDays = Math.Abs(coordinates[0] + coordinates[1]);
            int adjustment = travelDays % 5 == 0 ? 1 : 0;
            int restDays = (travelDays / 5) - adjustment;
            return travelDays + restDays;
        }

        // https://edabit.com/challenge/djCa8yiv5kYPhvcAZ
        public static string Accum(string str)
        {
            string result = string.Join("-", str.Select((c, index) =>
                char.ToUpper(c) + new string(char.ToLower(c), index)
            ));

            return result;
        }

        // https://edabit.com/challenge/u6HAot7ojYFTSm9aZ
        public static int Potatoes(string potato)
        {
            string pattern = "potato";
            MatchCollection matches = Regex.Matches(potato, pattern);
            return matches.Count;
        }

        // https://edabit.com/challenge/TLWqG49uMLa7zgxPE
        public static string Encrypt(string word)
        {
            string reversed = new string(word.ToCharArray().Reverse().ToArray());
            Dictionary<char, int> vowelValues = new Dictionary<char, int>
            {
                {'a', 0},
                {'e', 1},
                {'i', 2},
                {'o', 2},
                {'u', 3}
            };

            string replaced = new string(reversed.Select(c => vowelValues.ContainsKey(char.ToLower(c)) ? char.Parse(vowelValues[char.ToLower(c)].ToString()) : c).ToArray());
            string append = $"{replaced}aca";
            return append;
        }

        // https://edabit.com/challenge/dgHXtSrgyWbJ3cXvL
        public static int[] RemoveSmallest(int[] values)
        {
            if(values == null || values.Length == 0)
            {
                return new int[] { };
            }
            
            int minValue = values.Min();
            int minIndex = Array.IndexOf(values, minValue);
            int[] result = values.Where((val, index) => index != minIndex).ToArray();
            return result;
        }

        // https://edabit.com/challenge/uz4r69EHHSQMosT8D
        public static string MakeTitle(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            return string.Join(" ", words);
        }

        // https://edabit.com/challenge/egy6LWExtnR6JkwBg
        public static bool ValidateEmail(string str)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase);
        }

        // https://edabit.com/challenge/ToMXLjWDLQqFua7Wh
        public static string NoYelling(string phrase)
        {
            string[] words = phrase.Split(' ');
            words[words.Length - 1] = Regex.Replace(words[words.Length - 1], @"([?!])\1+", "$1");
            return string.Join(" ", words);
        }

        // https://edabit.com/challenge/NRAbyiQP9ZNa4bDRT
        public static int MysteryFunc(int num)
        {
            int product = 1;

            while (num > 0)
            {
                product *= num % 10;
                num /= 10;
            }

            return product;
        }

        // https://edabit.com/challenge/jxQTbif5fx7J8FeTT
        public static bool KToK(string n, int k)
        {
            return BigInteger.Pow(k, k) == BigInteger.Parse(n);
        }

    }
}
