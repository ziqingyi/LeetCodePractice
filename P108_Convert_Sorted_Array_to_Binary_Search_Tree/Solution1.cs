using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P108_Convert_Sorted_Array_to_Binary_Search_Tree
{
    public static class Solution1
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode result = buildBST(nums, 0, nums.Length - 1);
            return result;
        }


        private static TreeNode buildBST(int[] nums, int start, int end)
        {
            if (start > end) return null;
            int m = start + (end - start) / 2;

            TreeNode root = new TreeNode(nums[m]);
            root.left = buildBST(nums, start, m - 1);
            root.right = buildBST(nums, m + 1, end);
            return root;

        }
    }
}
