using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Net.Mime.MediaTypeNames;

namespace Edabit
{
    public static class Medium
    {
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
