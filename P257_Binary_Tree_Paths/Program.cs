using System;
using System.Collections;
using System.Collections.Generic;

namespace P257_Binary_Tree_Paths
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
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    null,
                    new TreeNode(5)),
                new TreeNode(3));

            IList<string> result = Solution1.BinaryTreePaths(root);



            //Console.ReadKey();
        }
    }


}
