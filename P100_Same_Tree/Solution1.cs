using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P100_Same_Tree
{
    /*
     *Runtime: 88 ms, faster than 90.05% of C# online submissions for Same Tree.
     * Memory Usage: 24.9 MB, less than 27.90% of C# online submissions for Same Tree.
     */

    public static class Solution1
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null)
            {
                return p == q;//cannot get value, so check whether they are null 
            }

            if (p.val != q.val)
            {
                return false;
            }


            return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
        }
    }
}
