using System;

namespace P226_Invert_Binary_Tree
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
                Input: root = [4,2,7,1,3,6,9]
                Output: [4,7,2,9,6,3,1]
             
                Input: root = [2,1,3]
                Output: [2,3,1]
                Example 3:

                Input: root = []
                Output: []
                
                Constraints:

                The number of nodes in the tree is in the range [0, 100].
                -100 <= Node.val <= 100
             */



            TreeNode root1 = new TreeNode(4,
                new TreeNode(2, 
                    new TreeNode(1), 
                    new TreeNode(3)),
                new TreeNode(7,
                    new TreeNode(6),
                    new TreeNode(9))
                );


            TreeNode result1 = Solution1.InvertTree(root1);



            Console.WriteLine("Hello World!");
        }
    }
}
