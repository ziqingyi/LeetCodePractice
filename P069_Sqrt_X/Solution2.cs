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
                return x;
            }

            int left = 1;
            int right = x;

            while (left < right)
            {
                int temp = (int)Math.Floor( ((decimal)right - left) / 2  );
                int mid = left + temp;

                long largeNum = (long)mid * mid;//must transfer to long when calculate

                if (largeNum < x)
                {
                    //get rid of left side by adding one,
                    //because you need to get the first num, with num^2 larger than x
                    //otherwise(left = mid) loop will never stop
                    left = mid+1;
                }

                if (largeNum > x)
                {
                    right = mid;
                }

                if (largeNum == x)
                {
                    return mid;
                }
            }

            return right - 1;



        }
    }
}
