using System;
using System.Collections.Generic;
using System.Text;

namespace P111_Minimum_Depth_of_Binary_Tree
{
    public static class Solution1
    {

        public static int MinDepth(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);

            int depth = 0;

            while (q.Count != 0)
            {
                int numberOfNode = q.Count;

                while (numberOfNode >0)
                {
                    TreeNode n = q.Dequeue();
                    if (n.left == null && n.right == null)
                    {
                        depth++;
                        return depth;
                    }

                    if (n.left != null)
                    {
                        q.Enqueue(n.left);
                    }

                    if (n.right != null)
                    {
                        q.Enqueue(n.right);
                    }

                    numberOfNode--;

                }

                depth++;
            }



            return depth;

        }


    }
}
