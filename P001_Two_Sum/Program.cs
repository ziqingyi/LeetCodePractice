using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
             * You may assume that each input would have exactly one solution, and you may not use the same element twice.
             * You can return the answer in any order.
             *
             *
             *
             */
             int[] nums1 = new []{2, 7, 11, 15};
             int target1 = 9;

             int[] result1 = TwoSum(nums1, target1);

             int[] nums2 = new[] {3,3 };
             int target2 = 6;

             int[] result2 = TwoSum(nums2, target2);



        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> d = new Dictionary<int, int>();

            //add one extra dic for handling 2 same value in d. 
            //if the value happens 3 or more times, it will not be part of solution, so do not consider it. 
            Dictionary<int,int> d_backup = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                if (!d.ContainsKey(nums[i]))
                {
                    d.Add(nums[i],i);
                }
                else if (!d_backup.ContainsKey(nums[i]))
                {
                    d_backup.Add(nums[i],i);
                }
                
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (d.ContainsKey(complement) && d[complement] != i)
                {
                    return new int[]{i, d[complement]};
                }
                else if (d_backup.ContainsKey(complement))
                {
                    return new int[]{i,d_backup[complement]};
                }
            }

            return new int[]{0,0};
        }



    }
}
