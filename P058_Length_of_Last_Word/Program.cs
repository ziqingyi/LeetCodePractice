using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given a string s consists of some words separated by spaces, 
            return the length of the last word in the string. 
            If the last word does not exist, return 0.

           A word is a maximal substring consisting of non-space characters only.

                   Example 1:

                   Input: s = "Hello World"
                   Output: 5
                   Example 2:

                   Input: s = " "
                   Output: 0

            */

            string input1 = "Hello World";
            int output1 = Solution1.LengthOfLastWord(input1);



        }
    }
}
