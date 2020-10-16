using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P009_Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
             * Follow up: Could you solve it without converting the integer to a string?

                Example 1:

                Input: x = 121
                Output: true
                Example 2:

                Input: x = -121
                Output: false
                Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
                Example 3:

                Input: x = 10
                Output: false
                Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
                Example 4:

                Input: x = -101
                Output: false
                 

                Constraints:

                -231 <= x <= 231 - 1
             *
             */

            int x1 = 12321;
            bool y1 = IsPalindrome(x1);

            int x2 = 11510;
            bool y2 = IsPalindrome(x2);



        }

     
        public static bool IsPalindrome(int x)
        {

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int reversedNum = 0;
            while (x > reversedNum)
            {
               reversedNum = reversedNum*10 + x % 10;
               x = x / 10;
            }

            if (x == reversedNum || x == reversedNum / 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
