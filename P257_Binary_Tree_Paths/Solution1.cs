using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace P257_Binary_Tree_Paths
{
    public class Solution1
    {
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();

            construct_path(root,"",paths);

            return paths;
        }

        public static void construct_path(TreeNode root, string path, List<string> paths)
        {
            if (root != null)
            {
                path += root.val.ToString();
                if (root.left == null && root.right == null)//reach a leaf
                {
                    paths.Add(path);
                }
                else
                {
                    path += "->";//extend the current path
                    construct_path(root.left, path,paths);
                    construct_path(root.right,path,paths);
                }
            }
        }



    }
}
