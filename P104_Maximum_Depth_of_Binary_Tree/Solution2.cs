using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P104_Maximum_Depth_of_Binary_Tree
{
    public static class Solution2
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            int maxDepth = 0;

            Solve(root, ref maxDepth);

            return maxDepth;
        }

        public static void Solve(TreeNode root, ref int maxDepth, int currDepth = 0)
        {
            if (root is null)
            {
                if (maxDepth < currDepth)
                {
                    maxDepth = currDepth;
                }

                return;
            }

            Solve(root.left,ref maxDepth, currDepth +1);
            Solve(root.right, ref maxDepth, currDepth +1);

        }


    }



}
