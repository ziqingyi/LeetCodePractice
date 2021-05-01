using System;
using System.Collections.Generic;
using System.Text;

namespace P111_Minimum_Depth_of_Binary_Tree
{
    public static class Solution1
    {
        //1 find the first node without any children in each level.
        //2 numberOfNode is used to check how many nodes in the current level.
        //   reset when the level is handled,-1 when dequeue
        //3 depth is calculate the tree depth, if current node have no child, add 1,
        //  otherwise when left & right are enqueue, add on

        public static int MinDepth(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int depth = 0;

            while (q.Count > 0)
            {
                int numberOfNodeInThisLevel = q.Count;
                
                while (numberOfNodeInThisLevel > 0)
                {
                   TreeNode node = q.Dequeue();

                    if (node.left == null && node.right == null)
                    {
                        return ++depth;
                    }

                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    numberOfNodeInThisLevel--;
                } 
                depth++;
            }
            return depth;
        }


    }
}
