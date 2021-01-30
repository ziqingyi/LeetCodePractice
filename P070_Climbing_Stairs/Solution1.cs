using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P070_Climbing_Stairs
{
    public class Solution1
    {
        /*
         *Runtime: 40 ms, faster than 68.55% of C# online submissions for Climbing Stairs.
         * Memory Usage: 15.4 MB, less than 11.68% of C# online submissions for Climbing Stairs.
         */

        public static int ClimbStairs(int n)
        {

            Dictionary<int,int> savedResults = new Dictionary<int,int>();

            return countingFunc(n, savedResults);

        }

        public static int countingFunc(int stairsRemaining,  Dictionary<int,int> savedResutlts)
        {
            if (stairsRemaining < 0)
            {
                return 0;
            }

            if (stairsRemaining == 0)
            {
                return 1;
            }

            if (savedResutlts.ContainsKey(stairsRemaining))
            {
                return savedResutlts[stairsRemaining];
            }

            savedResutlts[stairsRemaining] = countingFunc(stairsRemaining - 1, savedResutlts)
                                             + countingFunc(stairsRemaining - 2, savedResutlts);

            return savedResutlts[stairsRemaining];

        }

    }
}
