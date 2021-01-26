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
            #region Test
            //var a = Math.Pow(2, 4);//16
            //var b = Math.Log(Math.E);//b=1
            //var c = Math.Pow(Math.E, 0.5 * Math.Log(x));
            #endregion

            //Pocket Calculator Algorithm
            if (x < 2) return x;

            int left = (int)Math.Pow(Math.E, 0.5 * Math.Log(x));
            int right = left + 1;

            long temp = (long)right * right;

            int result = temp > x ? left : right;

            return result;
        }


    }
}
