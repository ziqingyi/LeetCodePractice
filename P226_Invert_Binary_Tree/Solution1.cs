using System;
using System.Collections.Generic;
using System.Text;

namespace P226_Invert_Binary_Tree
{
    public class Solution1
    {
 
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode right = InvertTree(root.right);

            TreeNode left = InvertTree(root.left);

            root.left = right;
            root.right = left;

            return root;

        }

    }
}
