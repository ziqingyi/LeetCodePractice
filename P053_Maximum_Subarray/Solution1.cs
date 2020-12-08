using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P053_Maximum_Subarray
{
    public class Solution1
    {
        
        public static int MaxSubArray(int[] nums)
        {
            int maxResult = helper(nums, 0, nums.Length - 1);
            return maxResult;
        }


        public static int helper(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return nums[left];
            }

            int p = (left + right) / 2;

            int leftSum = helper(nums, left, p);
            int rightSum = helper(nums, p + 1, right);
            int crossSum = Solution1.crossSum(nums, left, right, p);

            int result = Math.Max(Math.Max(leftSum, rightSum), crossSum);
            return result;
        }



        public static int crossSum(int[] nums, int left, int right, int p)
        {
            if (left == right)
            {
                return nums[left];
            }

            int leftSubsum = Int32.MinValue;

            int currSum = 0;

            for (int i = p; i > left - 1; --i)
            {
                currSum += nums[i];
                leftSubsum = Math.Max(leftSubsum, currSum);
            }

            int rightSubsum = Int32.MinValue;
            currSum = 0;
            for (int i = p + 1; i < right + 1; ++i)
            {
                currSum += nums[i];
                rightSubsum = Math.Max(rightSubsum, currSum);
            }

            return leftSubsum + rightSubsum;
        }







    }
}
