﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P069_Sqrt_X
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given a non-negative integer x, compute and return the square root of x.

            Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.

            Example 1:

            Input: x = 4
            Output: 2
            Example 2:

            Input: x = 8
            Output: 2
            Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
             
            Constraints:

            0 <= x <= 231 - 1
            */
            int x1 = 4;
            int r1 = Solution1.MySqrt(x1);

            long x2 = 21474836474;
            int r2 = Solution1.MySqrt(x2);



        }
    }
}