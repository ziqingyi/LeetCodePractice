using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P013_Roman_To_Integer
{
    public static class Solution1
    {
        public static int RomanToInt(string s)
        {

            if (string.IsNullOrEmpty(s)) 
                return 0;


            var dic = new Dictionary<char, int> {
                {'I', 1}, {'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D', 500},{'M', 1000}
            };

            int res = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int curVal = dic[s[i]];
                int nextVal = dic[s[i + 1]];

                if ( curVal > nextVal )
                {
                    res += curVal;
                }
                else
                {
                    res -= curVal;
                }
            }

            res += dic[s.Last()];
            return res;






        }

    }
}
