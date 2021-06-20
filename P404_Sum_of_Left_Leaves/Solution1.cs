using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace P404_Sum_of_Left_Leaves
{
    public static class Solution1
    {
        public static int SumOfLeftLeaves(TreeNode root)
        {
            int result = 0;
            GetSum(root, ref result);

            return result;

        }

        public static void GetSum(TreeNode root,ref int sum)
        {
            if (root != null)
            {
                //must be leaves,no left node or right node. 
                if (root.left != null && root.left.left == null && root.left.right == null)
                {
                    sum += root.left.val;
                }

                GetSum(root.left, ref sum);

                GetSum(root.right, ref sum);

            }


        }


    }
}
