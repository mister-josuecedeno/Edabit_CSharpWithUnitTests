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
using System.Globalization;

namespace Edabit
{
    public static class Medium
    {
        // https://edabit.com/challenge/TAZywz6R2hu9tDQWc
        public static bool Cons(int[] arr)
        {
            int maximum = arr.Max();
            int minimum = arr.Min();
            int expectedValues = maximum - minimum + 1;
            return arr.Length == expectedValues 
                && arr.Length == arr.Distinct().Count();
        }

        // https://edabit.com/challenge/8tyXtHqAT3LAuHMqu
        public static bool IsValidHexCode(string str)
        {
            // must begin with a '#'
            if (string.IsNullOrEmpty(str) || str[0] != '#')
            {
                return false;
            }
            
            // must be exactly 6 characters in length
            if (str.Length != 7)
            {
                return false;
            }

            // must contain only hexadecimal characters (0-9, a-f, A-F)
            for (int i = 1; i < str.Length; i++)
            {
                char c = str[i];
                if (!((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')))
                {
                    return false;
                }
            }

            return true;
        }

        // https://edabit.com/challenge/McGCFZYn8ikn3GSqz
        public static int PowerRanger(int power, int min, int max)
        {
            int start = (int)Math.Ceiling(Math.Pow(min, 1.0 / power));
            int end = (int)Math.Floor(Math.Pow(max, 1.0 / power));
            return Math.Max(0, end - start + 1);
        }

        // https://edabit.com/challenge/TH8Y97XYtGgbDW8Qw
        public static double[] FindVertex(int a, int b, int c)
        {
            // Find x coordinate
            double x = -(double)b / (2 * a);

            // Find y coordinate
            double y = a * x * x + b * x + c;

            // Round both values to 2 decimal places
            x = Math.Round(x, 2, MidpointRounding.AwayFromZero);
            y = Math.Round(y, 2, MidpointRounding.AwayFromZero);

            return new double[] { x, y };
        }

        // https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc
        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                char lastChar = words[i][words[i].Length - 1];
                char firstChar = words[i + 1][0];

                if (char.ToLower(lastChar) != char.ToLower(firstChar))
                {
                    return false;
                }
            }
            return true;
        }

        // https://edabit.com/challenge/wunaXvZw3WctYioeC
        public static string Uncensor(string txt, string vowels)
        {
            StringBuilder result = new StringBuilder();
            int vowelIndex = 0;
            foreach (char c in txt)
            {
                if (c == '*')
                {
                    result.Append(vowels[vowelIndex]);
                    vowelIndex++;
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        // https://edabit.com/challenge/FZ765MhPzbuTW7rzE
        public static string FlipEndChars(object str)
        {
            var strValue = str as string;

            if (strValue == null || strValue.Length < 2)
                return "Incompatible.";

            if (strValue[0] == strValue[strValue.Length - 1])
                return "Two's a pair.";

            return strValue[strValue.Length - 1] +
                   strValue.Substring(1, strValue.Length - 2) +
                   strValue[0];
        }

        // https://edabit.com/challenge/z2pzd2AJ3zr32uedG
        public static string SevenBoom(int[] arr)
        {
            bool containsSeven = arr.Any(x => x.ToString().Contains("7"));
            return containsSeven ? "Boom!" : "there is no 7 in the array";
        }

        // https://edabit.com/challenge/sSkPhsQjsHdT6Ri34
        public static int Schoty(string[] frame)
        {
            int[] arrays = frame.Select(x => x.Split(new string[] { "---" }, StringSplitOptions.None)[0].Length).ToArray();
            string number = string.Join("", arrays);
            return int.Parse(number);
        }

        // https://edabit.com/challenge/KEH9GYanedmB7Q4fT
        public static string AlternatingCaps(string str)
        {
            char[] chars = str.ToCharArray();
            int count = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]) == false)
                {
                    continue;
                }

                if (count % 2 == 0)
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                else
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                
                count++;
            }

            return new string(chars);
        }

        // https://edabit.com/challenge/zHXnh6Eoej7NrHvFu
        public static string IsPrime(int[] primes, int num)
        {
            int low = 0, high = primes.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // Check if x is present at mid
                if (primes[mid] == num)
                    return "yes";

                // If x greater, ignore left half
                if (primes[mid] < num)
                    low = mid + 1;

                // If x is smaller, ignore right half
                else
                    high = mid - 1;
            }

            // If we reach here, then element was
            // not present
            return "no";
        }

        // https://edabit.com/challenge/AafHF2YMGCqDRWERo
        public static string[] CapMe(string[] arr)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string[] result = arr.Select(x => textInfo.ToTitleCase(x.ToLower())).ToArray();
            return result;
        }

        // https://edabit.com/challenge/wkfN3Y6on8YnYnSvH
        public static int SumPrimes(int[] arr)
        {
            int[] primes = arr.Where(x => Easy.isPrime(x)).ToArray();
            return primes.Sum();
        }

        // https://edabit.com/challenge/fi5dqwejaQ5JQD7XP
        public static string TextToNum(string phone)
        {
            var letterToNumberLookup = new Dictionary<char, int>
            {
                {'A', 2}, {'B', 2}, {'C', 2},
                {'D', 3}, {'E', 3}, {'F', 3},
                {'G', 4}, {'H', 4}, {'I', 4},
                {'J', 5}, {'K', 5}, {'L', 5},
                {'M', 6}, {'N', 6}, {'O', 6},
                {'P', 7}, {'Q', 7}, {'R', 7}, {'S', 7},
                {'T', 8}, {'U', 8}, {'V', 8},
                {'W', 9}, {'X', 9}, {'Y', 9}, {'Z', 9}
            };

            StringBuilder result = new StringBuilder();

            foreach(char c in phone)
            {
                if (letterToNumberLookup.ContainsKey(c))
                {
                    result.Append(letterToNumberLookup[c]);
                } 
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        // https://edabit.com/challenge/k3R95H63Hj39t6iDn
        public static int[,] SquarePatch(int n)
        {
            if (n == 0)
            {
                return new int[0, 0];
            }

            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = n;
                }
            }

            return result;
        }

        // https://edabit.com/challenge/ukoc8ctGq6GkxJM76
        public static bool isFactorial(int n, int i = 1, int product = 1)
        {
            if (product == n) return true;  
            if (product > n) return false;  

            return isFactorial(n, i + 1, product * (i + 1)); 
        }

        // https://edabit.com/challenge/YxRSS8DEue6WNQqya
        public static string WurstIsBetter(string str)
        {
            List<string> convertToWurst = new List<string>
            {
                "Kielbasa", "Chorizo", "Moronga", "Salami", "Sausage", "Andouille",
                "Naem", "Merguez", "Gurka", "Snorkers", "Pepperoni"
            };

            string replacement = "Wurst";

            string pattern = "\\b(" + string.Join("|", convertToWurst) + ")\\b";

            string result = Regex.Replace(str, pattern, replacement, RegexOptions.IgnoreCase);

            return result;
        }

        // https://edabit.com/challenge/8qkRcwf4ARtXpdwEW
        public static int MajorSum(int[] arr)
        {
            int positives = arr.Where(x => x > 0).Sum();
            int negatives = arr.Where(x => x < 0).Sum();
            int zeroes = arr.Count(x => x == 0);

            int[] results = { positives, negatives, zeroes };

            int major = results.OrderByDescending(Math.Abs).First();

            return major;
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
