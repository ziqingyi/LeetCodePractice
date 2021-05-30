using System;

namespace P112_Path_Sum
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
            /*
             *Given the root of a binary tree and an integer targetSum,
             *return true if the tree has a root-to-leaf path such that adding up all the values along the path equals target Sum.
             * A leaf is a node with no children.
             *
             *
             */

            TreeNode root1 = new TreeNode(5,
                new TreeNode(4,
                    new TreeNode(11,
                        new TreeNode(7, 
                            new TreeNode(2)))),
                
                new TreeNode(8,
                    new TreeNode(13),
                    new TreeNode(4, 
                        null,
                        new TreeNode(1)
                    )));







            Console.ReadKey();
        }
    }
}
