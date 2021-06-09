using System;
using System.Collections.Generic;

namespace P145_Binary_Tree_Postorder_Traversal
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


            TreeNode root1 = new TreeNode(1,
                null,
                new TreeNode(2,
                    new TreeNode(3),
                    null));


            IList<int> result1 = Solution1.PostorderTraversal(root1);





            Console.WriteLine("Hello World!");
        }
    }
}
