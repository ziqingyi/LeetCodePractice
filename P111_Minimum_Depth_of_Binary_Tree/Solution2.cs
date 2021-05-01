using System;
using System.Collections.Generic;
using System.Text;

namespace P111_Minimum_Depth_of_Binary_Tree
{
    public static class Solution2
    {

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if(root.left == null)
            {
                return MinDepth(root.right)+1;
            }
            if (root.right == null)
            {
                return MinDepth(root.left) +1;
            }

            int depthL = MinDepth(root.left);
            int depthR = MinDepth(root.right);

            int depth = depthL < depthR ? depthL +1: depthR+1;

            return depth;

        }


    }
}
