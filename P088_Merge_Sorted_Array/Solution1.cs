using System;
using System.Collections.Generic;
using System.Text;

namespace P088_Merge_Sorted_Array
{
    public static class Solution1
    {
        /*
         *Runtime: 232 ms, faster than 89.44% of C# online submissions for Merge Sorted Array.
         *Memory Usage: 30.9 MB, less than 77.58% of C# online submissions for Merge Sorted Array
         */
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int first = m - 1;
            int second = n - 1;

            if (first < 0)
            {
                Array.Copy(nums2,nums1,nums2.Length);
                //nums1 = nums2;//wrong
            }
            else
            {

                for (int i = m + n - 1; i >= 0; i--)
                {
                    if (second < 0)
                    {
                        break;
                    }

                    if (first >= 0 &&   nums1[first] > nums2[second])
                    {
                        nums1[i] = nums1[first];
                        first--;
                    }

                    else
                    {
                        nums1[i] = nums2[second];
                        second--;
                    }
                }
            }


        }


    }
}
