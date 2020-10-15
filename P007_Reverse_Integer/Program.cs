using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P007_Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a 32-bit signed integer, reverse digits of an integer.
             * Note:
             *     Assume we are dealing with an environment that
             *     could only store integers within the 32-bit signed integer range: [−231,  231 − 1].
             *     For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
             */

            int xx = int.MaxValue;

            //int x1 = 123;
            //int y1 = Reverse(x1);

            int x2 = 1534236469;
            int y2 = Reverse(x2);
            


        }
        
        public static int Reverse(int x)
        {
            if (x < 10 && x > -10)
            {
                return x;
            }

            List<int> digits = new List<int>();
            int iTemp = x;

            do
            {
                digits.Add(iTemp %10);
                iTemp = iTemp / 10;

            } while (iTemp !=0);

            int i = digits.Count;

            Int64 iFactor = 1;
            Int64 iResult = 0;

            while (i>0)
            {
                --i;

                iResult += iFactor * digits[i];

                iFactor *= 10;

            }

            if (iResult >int.MaxValue || iResult <int.MinValue)
            {
                return 0;
            }
            return Convert.ToInt32(iResult);

        }




    }
}
