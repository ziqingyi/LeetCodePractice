using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace P111_Minimum_Depth_of_Binary_Tree
{
    public static class Solution2
    {

        public static int MinDepth(TreeNode root)
        {
            #region 1 If root is empty
            if (root == null)
            {
                return 0;
            }
              
            #endregion

            int depthL;
            int depthR;

            #region 2 if one of the subtree is empty
            //the depth of the tree is decided by the height of subtree
            //if one side is empty, the other side's depth + 1 is the whole tree's depth.
            if (root.left == null)
            {
                depthR = MinDepth(root.right) +1;
                return depthR;
            }

            if (root.right == null)
            {
                depthL = MinDepth(root.left) +1;
                return depthL;
            }
            #endregion

            #region 3 if both subtree is not empty, compare

            depthL = MinDepth(root.left);
            depthR = MinDepth(root.right);

            int depth = Math.Min(depthL, depthR) + 1;
            return depth;            

            #endregion


        }
        
    }
}
