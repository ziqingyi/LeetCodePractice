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
            //int a1 = int.Parse(a);
            //int b1 = int.Parse(b);
            //string r = Convert.ToString(int.Parse(a), 2)+ Convert.ToString(int.Parse(b), 2);

            //int dec = Convert.ToInt32(a, 2);
            //string re = Convert.ToString(dec, 2);
            string re = Convert.ToString(Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2), 2);




            return re;
        }


    }
}
