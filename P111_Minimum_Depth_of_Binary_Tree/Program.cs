using System;

namespace P111_Minimum_Depth_of_Binary_Tree
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
        /*
         Given a binary tree, find its minimum depth.The minimum depth is 
         the number of nodes along the shortest path from the root node down to the nearest leaf node.

            if one side is empty, the depth of the tree is decided by the other

            minimum depth is the relative lower side of the sub tree. 

        */
        static void Main(string[] args)
        {

            TreeNode root1 = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20,
                    new TreeNode(15),
                    new TreeNode(7)));

            //int result1 = Solution1.MinDepth(root1);
            //int result2 = Solution2.MinDepth(root1);


            TreeNode root2 = new TreeNode(1,
                new TreeNode(2,new TreeNode(4),
                    new TreeNode(5))
               // ,new TreeNode(3, new TreeNode(6))
                );

            int result3 = Solution2.MinDepth(root2);



        }
    }
}
