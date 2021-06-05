using System;
using System.Collections.Generic;

namespace P144_Binary_Tree_Preorder_Traversal
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

        //Given the root of a binary tree, return the preorder traversal of its nodes' values.

        static void Main(string[] args)
        {
        
            TreeNode root1 = new TreeNode(1,
            null,
            new TreeNode(2,
                new TreeNode(3),
                null));


            IList<int> result1 = Solution1.PreorderTraversal(root1);









            Console.WriteLine("Hello World!");
        }
    }
}
