using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Easy
    {
        // https://edabit.com/challenge/moqcQ563NukBBbKDL
        public static string LettersOnly(string str)
        {
            return string.Empty;
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
