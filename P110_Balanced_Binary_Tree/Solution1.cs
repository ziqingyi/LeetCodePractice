using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_Balanced_Binary_Tree
{
    public class Solution1
    {
        /*
         Runtime: 104 ms, faster than 32.32% of C# online submissions for Balanced Binary Tree.
         Memory Usage: 27.9 MB, less than 59.44% of C# online submissions for Balanced Binary Tree.
         Next challenges:
         */
        public static bool IsBalanced(TreeNode root)
        {

            return GetHeight(root) != -1;
        }


        public static int GetHeight(TreeNode root)
        {
            #region case 1 : for null, contribute to hight with 0
            if (root == null)
            {
                return 0;
            }
            #endregion


            int right = GetHeight(root.right);
            int left = GetHeight(root.left);


            #region case 2 : If has un-banlaced sub tree, then the whole tree is not balanced
            if (right == -1 || left == -1 || Math.Abs(left - right) > 1)
            {
                return -1;
            }
            #endregion


            #region case 3: just return the hight

            return Math.Max(right, left)+1;

            #endregion

            

        }



    }
}
