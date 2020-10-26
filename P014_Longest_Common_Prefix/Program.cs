using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P014_Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a function to find the longest common prefix string amongst an array of strings.

            If there is no common prefix, return an empty string "".

             

            Example 1:

            Input: strs = ["flower","flow","flight"]
            Output: "fl"
            Example 2:

            Input: strs = ["dog","racecar","car"]
            Output: ""
            Explanation: There is no common prefix among the input strings.
             

            Constraints:

            0 <= strs.length <= 200
            0 <= strs[i].length <= 200
            strs[i] consists of only lower-case English letters.

             */


            string[] strs1 = new String[]{"flower", "flow", "flight"} ;

            string result1 = Solution1.LongestCommonPrefix(strs1);








        }
    }
}
