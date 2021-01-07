using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P067_Add_Binary
{
    public class Solution1
    {
        public static string AddBinary(string a, string b)
        {
            #region quick solution, but failed with large numbers
            //int a1 = int.Parse(a);
            //int b1 = int.Parse(b);
            //string r = Convert.ToString(int.Parse(a), 2)+ Convert.ToString(int.Parse(b), 2);

            //int dec = Convert.ToInt32(a, 2);//convert from binary to decimal, 2 is base
            //string re = Convert.ToString(dec, 2);

            //Get result: 
            ////Int64 a1 = Convert.ToInt64(a, 2);
            ////Int64 a2 = Convert.ToInt64(b, 2);
            ////string re = Convert.ToString(a1+a2, 2);
            #endregion

            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                //find sum for each position
                //add carry first, then add i and j number separately
                // %2 get remainder, put to sb
                // /2 get carry, used for next sum.

                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i]-48;
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j]-48;
                    j--;
                }
                sb.Insert(0, sum %2);
                carry = sum / 2;
            }

            if (carry > 0)
            {
                sb.Insert(0, 1);
            }

            return sb.ToString();

        }


    }
}
