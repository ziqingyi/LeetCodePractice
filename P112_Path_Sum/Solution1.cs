using System;
using System.Collections.Generic;
using System.Text;

namespace P112_Path_Sum
{
    public class Solution1
    {

        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.val == targetSum && root.left == null && root.right == null)
            {
                return true;
            }

            bool result = HasPathSum(root.left, targetSum - root.val)
                || HasPathSum(root.right, targetSum - root.val);

            return result;
        }


    }
}
