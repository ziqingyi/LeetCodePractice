using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P066_Plus_One
{
    public static class Solution1
    {
        public static int[] PlusOne(int[] digits)
        {
            int total = digits.Length;
            for (int i = total - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            digits = new int[total+1];
            digits[0] = 1;
            return digits;

        }
    }
}
