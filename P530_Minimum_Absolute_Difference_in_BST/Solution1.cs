using System;
using System.Collections.Generic;
using System.Text;

namespace P530_Minimum_Absolute_Difference_in_BST
{
    public static class Solution1
    {
        private static  int _minGap = int.MaxValue;
        private static int? _prev = null;
        public static int GetMinimumDifference(TreeNode root)
        {
            InOrder(root);
            return _minGap;
        }

        private static void InOrder(TreeNode root)
        {
            if (root == null)
                return;
            if (root.left != null)
            {
                InOrder(root.left);
            }

            if (_prev != null)
            {
                int temp = Convert.ToInt32(_prev);
                _minGap = _minGap < root.val - _prev ? _minGap : root.val - temp;
                _prev = root.val;
            }

            if (_prev is null)
            {
                _prev = root.val;
            }

            if (root.right != null)
            {
                InOrder(root.right);
            }


        }


    }
}
