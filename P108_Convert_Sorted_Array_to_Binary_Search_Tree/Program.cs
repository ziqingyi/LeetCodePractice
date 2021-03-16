using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P108_Convert_Sorted_Array_to_Binary_Search_Tree
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
            Given an integer array nums where the elements are sorted in ascending order, 
            convert it to a height-balanced binary search tree.
            A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.
            
             Input: nums = [-10,-3,0,5,9]
             Output: [0,-3,9,-10,null,5]
             Explanation: [0,-10,5,null,-3,null,9] is also accepted:
             
            Input: nums = [1,3]
            Output: [3,1]
            Explanation: [1,3] and [3,1] are both a height-balanced BSTs.
 

            Constraints:

            1 <= nums.length <= 104
            -104 <= nums[i] <= 104
            nums is sorted in a strictly increasing order.

             */















        }
    }
}
