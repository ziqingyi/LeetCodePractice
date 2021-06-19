using System;
using System.Collections.Generic;
using System.Text;

namespace P235_Lowest_Common_Ancestor_of_Binary_Search_Tree
{
    public class Solution1
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p == null || q == null || root == null)
            {
                return null;
            }
            
            if (p.val < root.val && q.val < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }

            if (p.val > root.val && q.val > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }

            return root;

        }


    }
}
