﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Edabit
{
    public static class Easy
    {
        // https://edabit.com/challenge/G4DQHo2YgDBAxBJH8
        public static int Pentagonal(int num)
        {
            return (5 * num * num - 5 * num + 2) / 2; ;
        }

        // https://edabit.com/challenge/n5Q8vWopD3Kmc8ADi
        public static bool IsValidPhoneNumber(string str)
        {
            string pattern = @"^\(\d{3}\)\s\d{3}-\d{4}$";
            return Regex.IsMatch(str, pattern);
        }

        // https://edabit.com/challenge/dgHXtSrgyWbJ3cXvL
        public static int[] RemoveSmallest(int[] values)
        {
            int min = values.Min();
            int indexToRemove = Array.IndexOf(values, min);
            return values.Where((value, arrayIndex) => arrayIndex != indexToRemove).ToArray();
        }

        // https://edabit.com/challenge/XovEQex684EnTcZqA
        public static string Century(int year)
        {
            string suffix = year > 2000 ? "st" : "th";
            int century = 0;

            if (year % 100 == 0) { 
                century = year / 100;
            }
            else { 
                century = (year / 100) + 1;
            }

            return $"{century}{suffix} century";
        }

        // https://edabit.com/challenge/AyCKKtuhYjNo9eYwJ
        public static int LargestGap(int[] arr)
        {
            int[] sortedNumbers = arr.OrderBy(x => x).ToArray();

            return sortedNumbers
                .Zip(sortedNumbers.Skip(1), (current, next) => next - current)
                .Max();
        }

        // https://edabit.com/challenge/uz6HACQLjH9DE6HcP
        public static decimal MyPi(int n)
        {
            decimal pi = (decimal)Math.PI;
            return Math.Round(pi, n);
        }

        // https://edabit.com/challenge/H77JNgLtEnQcX5hcu
        public static bool IsSymmetrical(int num)
        {
            string number = num.ToString();
            char[] chars = number.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            
            return num.ToString() == reversed;
        }

        // https://edabit.com/challenge/5B4jvew2NvzKhfcQv
        public static bool CheckPerfect(int num)
        {
            List<int> list = new List<int>();

            for (int i = 1; i < num; i++) { 
                if(num % i == 0)
                {
                    list.Add(i);
                }
            }

            int sum = list.Sum();

            return sum == num;
        }

        // https://edabit.com/challenge/SfZx7qzXheYQxtQbF
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, @"[^a-zA-Z0-9\s\-_]", "");
        }

        // https://edabit.com/challenge/ynZfn2LifKN25fP84
        public static string FindNemo(string sentence)
        {
            string[] words = sentence.Split(' ');
            int location = Array.IndexOf(words, "Nemo");

            if (location == -1)
            {
                return "I can't find Nemo :(";
            }

            return $"I found Nemo at {location + 1}!";
        }

        // https://edabit.com/challenge/7F8ZhHpxeW7K65XRL
        public static int SumSmallest(int[] values)
        {
            int[] positives = values.Where(x => x > 0).OrderBy(n => n).ToArray();
            return positives[0] + positives[1];
        }

        // https://edabit.com/challenge/aoR4PFS6FfpJs6v79
        public static bool isPrime(int x)
        {
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return x > 1;
        }

        // https://edabit.com/challenge/8Sc582yHht2auBpCY
        public static bool IsStrangePair(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) && string.IsNullOrEmpty(str2))
            {
                return true;
            }

            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return false;
            }

            char firstFirst = str1[0];
            char secondLast = str2[str2.Length - 1];
            char firstLast = str1[str1.Length - 1];
            char secondFirst = str2[0];
            return firstFirst == secondLast && firstLast == secondFirst;
        }

        // https://edabit.com/challenge/biJhNvddqC5zmRuKz
        public static bool HasFriday13th(int month, int year)
        {
            DateTime today = new DateTime(year: year, month: month, day: 13); 
            return today.DayOfWeek == DayOfWeek.Friday;
        }

        // https://edabit.com/challenge/N5G33s49LDXdhLdsT
        public static int SortDescending(int num)
        {
            string numberStr = num.ToString();
            string sortedStr = new string(numberStr.OrderByDescending(c => c).ToArray());
            int sortedNumber = int.Parse(sortedStr);

            return sortedNumber;
        }

        // https://edabit.com/challenge/aQWAAz6SiApZBA8A8
        public static bool IsIsogram(string str)
        {
            HashSet<char> set = new HashSet<char>(str.ToLower());
            return set.Count == str.Length;
        }

        // https://edabit.com/challenge/qrJyh8ouvr2iseZy4
        public static bool IsPalindrome(int num)
        {
            if (num < 0) return false; 

            int original = num;
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            return original == reversed;
        }

        // https://edabit.com/challenge/j34NRDnwRC2YgGPXN
        public static int Tetra(int n)
        {
            return (n * (n + 1) * (n + 2)) / 6;
        }

        // https://edabit.com/challenge/4eSei6t8emzpyMwvu
        public static int[] FilterArray(object[] arr)
        {
            return arr.OfType<int>().ToArray();
        }

        // https://edabit.com/challenge/GvGSPC9wiY4bS9AMg
        public static string FormatNum(int num)
        {
            if (num == 0) return "0";
            string result = num.ToString("#,#", CultureInfo.InvariantCulture);
            return result;
        }

        // https://edabit.com/challenge/zcuASzWmpFHpPtrbH
        public static string HighLow(string str)
        {
            string[] arr = str.Split(' ');
            int[] numbers = Array.ConvertAll(arr, int.Parse);
            Array.Sort(numbers, (a, b) => b.CompareTo(a));
            int largest = numbers[0];
            int smallest = numbers[numbers.Length - 1];
            return $"{largest} {smallest}";
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
