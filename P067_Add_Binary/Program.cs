using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P067_Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Given two binary strings a and b, return their sum as a binary string.
             * Example 1:

                Input: a = "11", b = "1"
                Output: "100"
                Example 2:

                Input: a = "1010", b = "1011"
                Output: "10101"
                 
                Constraints:

                1 <= a.length, b.length <= 104
                a and b consist only of '0' or '1' characters.
                Each string does not contain leading zeros except for the zero itself.

             */
            string a1= "11";
            string b1 = "1";
            string s1 = Solution1.AddBinary(a1, b1);



        }
    }
}
