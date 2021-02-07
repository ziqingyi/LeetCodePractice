using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P101_Symmetric_Tree
{
    /** Definition for a binary tree node.*/
   public class TreeNode {
       public int val;
       public TreeNode left;
       public TreeNode right;
       public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
           this.val = val;
           this.left = left;
           this.right = right;
       }
   }
 
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given a binary tree, check whether it is a mirror of itself(ie, symmetric around its center).

            For example, this binary tree[1, 2, 2, 3, 4, 4, 3] is symmetric:
            But the following [1,2,2,null,3,null,3] is not:
            Follow up: Solve it both recursively and iteratively.
            */

            TreeNode tree1 = new TreeNode(1, 
                new TreeNode(2, null, new TreeNode(3)), 
                new TreeNode(2, null, new TreeNode(3)));
            
            bool isSame1 = Solution1.IsSymmetric(tree1);



            TreeNode tree2 = new TreeNode(1, 
               new TreeNode(2, new TreeNode(3), new TreeNode(4)), 
               new TreeNode(2, new TreeNode(4), new TreeNode(3)));

            bool isSame2 = Solution1.IsSymmetric(tree2);


        }
    }
}
