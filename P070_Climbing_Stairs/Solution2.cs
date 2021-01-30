using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P070_Climbing_Stairs
{
    public static class Solution2
    {
        /*
         *Runtime: 40 ms, faster than 68.55% of C# online submissions for Climbing Stairs.
         *
         * Memory Usage: 15.1 MB, less than 67.21% of C# online submissions for Climbing Stairs.
         */
        public static int ClimbStairs(int n)
        {
            if (n < 3)
            {
                return n;
            }

            int n_1 = 1;
            int n_2 = 2;
            int res = 0;

            int i = 3;

            while (i++ <= n)
            {
                res = n_1 + n_2;
                n_1 = n_2;
                n_2 = res;
            }

            return res;
        }




    }






}
