using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Length_of_Last_Word
{
    public static class Solution1
    {
        public static int LengthOfLastWord(string s)
        {
            if (s.Trim().Length == 0)
            {
                return 0;
            }

            string[] words = s.Trim().Split(' ');
            int result = words[words.Length - 1].Length;

            return result;


        }


    }
}
