using System;
using System.Collections.Generic;

namespace P404_Sum_of_Left_Leaves
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root2 = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3));

            int result2 = Solution1.SumOfLeftLeaves(root2);




            TreeNode root = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20,
                    new TreeNode(15),
                    new TreeNode(7)));

            int result1 = Solution1.SumOfLeftLeaves(root);








            Console.ReadKey();
        }
    }
}
