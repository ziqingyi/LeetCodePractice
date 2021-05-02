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
                    new TreeNode(5)),
                new TreeNode(3, new TreeNode(6)
                    ));

            int result3 = Solution2.MinDepth(root2);



        }
    }
}
