using System;

namespace P530_Minimum_Absolute_Difference_in_BST
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
            //Given the root of a Binary Search Tree (BST),
            //return the minimum absolute difference between the values of any two different nodes in the tree.

            TreeNode root = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3)),
                new TreeNode(6));

            int result = Solution1.GetMinimumDifference(root);










            Console.WriteLine("Hello World!");
        }
    }
}
