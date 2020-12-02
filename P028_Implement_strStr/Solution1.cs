using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P028_Implement_strStr
{
    public static class Solution1
    {
        public static int StrStr(string haystack, string needle)
        {
            int l = needle.Length;
            int n = haystack.Length;

            for (int start = 0; start < n-l+1; start++)
            {
                string temp = haystack.Substring(start, l);
                if (temp == needle)
                {
                    return start;
                }
            }

            return -1;

        }
    }
}
