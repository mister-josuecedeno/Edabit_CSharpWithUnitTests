using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Very_Easy
    {
        public static int ReturnNegative(int n)
        {
            return n < 0 ? n : n * -1;
        }

        public static int area(int h, int w)
        {
            if (h <= 0 || w <= 0) return -1;
            return h * w;
        }
    }
}
