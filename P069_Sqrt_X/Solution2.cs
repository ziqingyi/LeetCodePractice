using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P069_Sqrt_X
{
    public class Solution2
    {
        public static int MySqrt(int x)
        {
            if (x < 2)
            {
                return (int)x;
            }

            int left = 1;
            int right = x;

            while (left < right)
            {
                int temp = (right - left) / 2;
                int mid = left + (int)Math.Floor((decimal)temp);
                long largeNumber =(long)mid * mid;

                if (largeNumber == x)
                {
                    return (int)mid;
                }
                else if (largeNumber > x)
                {
                    right = mid;
                }
                else if ( largeNumber < x)
                {
                    left = mid + 1;
                }
            }

            //var dd = left - 1;
            return (int)(left - 1);



        }
    }
}
