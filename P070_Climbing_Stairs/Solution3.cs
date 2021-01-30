using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P070_Climbing_Stairs
{
    public static class Solution3
    {
        /*
         *Runtime: 40 ms, faster than 68.55% of C# online submissions for Climbing Stairs.
         *
         * Memory Usage: 15.2 MB, less than 35.31% of C# online submissions for Climbing Stairs.
         */
        public static int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            int[] res = new int[n+1];

            res[1] = 1;
            res[2] = 2;

            for (int i = 3; i <= n ; i++)
            {
                res[i] = res[i - 1] + res[i - 2];
            }

            return res[n];

        }

    }
}
