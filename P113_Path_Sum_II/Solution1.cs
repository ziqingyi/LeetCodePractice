using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace P113_Path_Sum_II
{
    public class Solution1
    {

        public static IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {

            IList<IList<int>> paths = new List<IList<int>>();
            
            find_path(root, targetSum,"", paths);

            return paths;

        }

        public static void find_path(TreeNode root,int targetSum, string path, IList<IList<int>> paths)
        {
            if (root != null)
            {
                path +=root.val.ToString(); 
                
                //reach a leaf and leaf route value is equal to target sum
                if ( targetSum == root.val &&  root.left == null && root.right == null)
                {
                    paths.Add(path.Split(',').Select(Int32.Parse).ToList());
                }
                else
                {
                    path += ",";//extend the current path
                    find_path(root.left,targetSum - root.val, path, paths);
                    find_path(root.right, targetSum - root.val, path, paths);
                }
            }
        }


    }
}
