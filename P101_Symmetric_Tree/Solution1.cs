using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P101_Symmetric_Tree
{
    public static class Solution1
    {
        /**
         *Runtime: 100 ms, faster than 38.78% of C# online submissions for Symmetric Tree.
         *Memory Usage: 26 MB, less than 12.84% of C# online submissions for Symmetric Tree.
         */


        public static bool IsSymmetric(TreeNode root)
        {
            if (root is null)
            {
                return true;
            }

            return isMirror(root.left, root.right);

        }

        public static bool isMirror(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;//check whether all null
            }

            if (left.val != right.val)
            {
                return false;
            }

            //use for debug
            bool isMirrorLeft = isMirror(left.left, right.right);
            bool isMirrorRight = isMirror(left.right, right.left);
            return isMirrorLeft && isMirrorRight;

        }


    }
}
