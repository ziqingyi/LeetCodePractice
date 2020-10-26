using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P014_Longest_Common_Prefix
{
    public static class Solution1
    {

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length <= 0)
            {
                return "";
            }

            string prefix = "";

            for (int j = 0; j < strs[0].Length; j++)
            {
                char c = (strs[0])[j];

                for (int i = 1; i < strs.Length; i++)
                {
                    if (j >= strs[i].Length || (strs[i])[j] != c)
                    {
                        return prefix;
                    }
                }

                prefix += c;



            }


            return prefix;

        }

    }
}
