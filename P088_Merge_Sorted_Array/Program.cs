using System;

namespace P088_Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
             * The number of elements initialized in nums1 and nums2 are m and n respectively.
             * You may assume that nums1 has a size equal to m + n such that it has enough space to hold additional elements from nums2.

                Example 1:

                Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
                Output: [1,2,2,3,5,6]
                Example 2:

                Input: nums1 = [1], m = 1, nums2 = [], n = 0
                Output: [1]
                 
                Constraints:

                nums1.length == m + n
                nums2.length == n
                0 <= m, n <= 200
                1 <= m + n <= 200
                -109 <= nums1[i], nums2[i] <= 109
             */


            int[] num31 = { 2,0 };
            int[] num32 = { 1 };
            Solution1.Merge(num31, 1, num32, num32.Length);



            int[] num11 = { 1, 2, 3, 0, 0, 0 };
            int[] num12 = { 2, 5, 6 };
            Solution1.Merge(num11,num11.Length-num12.Length, num12, num12.Length);



            int[] num21 = { 0 };
            int[] num22 = { 1 };
            Solution1.Merge(num21, 0, num22, num22.Length);



        }
    }
}
