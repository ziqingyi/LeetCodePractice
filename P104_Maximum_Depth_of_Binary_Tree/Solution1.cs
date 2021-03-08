using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P104_Maximum_Depth_of_Binary_Tree
{


    public static class Solution1
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int left_height = MaxDepth(root.left);
                int right_height = MaxDepth(root.right);
                int cur_max_height = left_height > right_height ? left_height : right_height ;
                return cur_max_height+1;
            }



        }


    }
}
