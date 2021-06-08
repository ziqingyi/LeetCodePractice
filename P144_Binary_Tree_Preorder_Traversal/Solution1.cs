using System;
using System.Collections.Generic;
using System.Text;

namespace P144_Binary_Tree_Preorder_Traversal
{
    public class Solution1
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();

            Preorder(list,root);

            return list;

        }


        public static void Preorder(IList<int> l, TreeNode root)
        {
            if (root != null)
            {
                l.Add(root.val);

                Preorder(l, root.left);

                Preorder(l, root.right);
            }
        }



    }
}
