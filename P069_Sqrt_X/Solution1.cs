using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P069_Sqrt_X
{
    public static class Solution1
    {
        public static int MySqrt(int x)
        {
            if (x < 2) return x;

            int left = (int)Math.Pow(Math.E, 0.5 * Math.Log(x));
            int right = left + 1;

            int result = right * right > x ? left : right;

            return result;
        }


    }
}
