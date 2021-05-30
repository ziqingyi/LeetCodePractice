using System;
using System.Collections;
using System.Collections.Generic;

namespace P113_Path_Sum_II
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
         * Given the root of a binary tree and an integer targetSum,
         * return all root-to-leaf paths where each path's sum equals targetSum.
         * A leaf is a node with no children.
         */

        /*First Medium problem and solved by myself. 
         *
         * Success
         * Details
         *
         * Runtime: 252 ms, faster than 36.64% of C# online submissions for Path Sum II.
         *
         * Memory Usage: 34.5 MB, less than 30.15% of C# online submissions for Path Sum II.
         *
         *
         *
         */



        static void Main(string[] args)
        {

            TreeNode root1 = new TreeNode(5,
                new TreeNode(4,
                    new TreeNode(11,
                        new TreeNode(7),
                        new TreeNode(2))),

                new TreeNode(8,
                    new TreeNode(13),
                    new TreeNode(4,
                        new TreeNode(5),
                        new TreeNode(1)
                    )));


            IList<IList<int>> result = Solution1.PathSum(root1, 22);



            Console.ReadKey();
        }
    }
}
