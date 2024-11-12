using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Edabit
{
    public static class Medium
    {
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
