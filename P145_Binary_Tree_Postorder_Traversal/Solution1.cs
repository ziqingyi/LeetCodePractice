using System;
using System.Collections.Generic;
using System.Text;

namespace P145_Binary_Tree_Postorder_Traversal
{
    public  class Solution1
    {
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();

            Postorder(list, root);

            return list;

        }

        public static void Postorder(IList<int> l, TreeNode root)
        {
            if (root != null)
            {
                Postorder(l,root.left);

                Postorder(l,root.right);

                l.Add(root.val);
            }


        }


    }
}
