using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P027_Remove_Element
{
    public static class Solution1
    {
        public static int RemoveElement(int[] nums, int val)
        {
          
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;

        }

    }
}
