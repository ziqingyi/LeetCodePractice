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

            //note: c# int has max/min value
            //Int64 x = 9223372036854775807;
            //string xx = Convert.ToString(x, 2);
             */
            string a1= "11";
            string b1 = "10";
            string s1 = Solution1.AddBinary(a1, b1);//101



            string a2 = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
            string b2 = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";
            string s2 = Solution1.AddBinary(a2, b2);


            
            
        }
    }
}
