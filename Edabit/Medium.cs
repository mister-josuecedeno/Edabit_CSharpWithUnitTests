using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Medium
    {
        // https://edabit.com/challenge/jxQTbif5fx7J8FeTT
        public static bool KToK(string n, int k)
        {
            return BigInteger.Pow(k, k) == BigInteger.Parse(n);
        }

    }
}
