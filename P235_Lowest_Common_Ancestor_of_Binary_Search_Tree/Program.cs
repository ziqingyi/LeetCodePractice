using System;

namespace P235_Lowest_Common_Ancestor_of_Binary_Search_Tree
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
            TreeNode root1 = new TreeNode(6,
                new TreeNode(2,
                    new TreeNode(0),
                    new TreeNode(4,
                        new TreeNode(3),
                        new TreeNode(5))),
                new TreeNode(8,
                    new TreeNode(7),
                    new TreeNode(9))
            );


            TreeNode result1 = Solution1.LowestCommonAncestor(root1,
                new TreeNode(2),
                new TreeNode(8));


            TreeNode result2 = Solution1.LowestCommonAncestor(root1,
                new TreeNode(2),
                new TreeNode(4));



            Console.WriteLine("Hello World!");
        }
    }
}
