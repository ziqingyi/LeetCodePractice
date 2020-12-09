using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_Maximum_Subarray
{
    public class Solution2
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxCurrent = nums[0];
            int maxGlobal = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                maxCurrent = Math.Max(nums[i], maxCurrent + nums[i]);
                if (maxCurrent > maxGlobal)
                {
                    maxGlobal = maxCurrent;
                }
            }

            return maxGlobal;
        }



    }
}
