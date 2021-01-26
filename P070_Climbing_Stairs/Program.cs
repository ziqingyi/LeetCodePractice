using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P070_Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *You are climbing a staircase. It takes n steps to reach the top.
             * Each time you can either climb 1 or 2 steps.
             * In how many distinct ways can you climb to the top?
                
            Example 1:

            Input: n = 2
            Output: 2
            Explanation: There are two ways to climb to the top.
            1. 1 step + 1 step
            2. 2 steps
            Example 2:

            Input: n = 3
            Output: 3
            Explanation: There are three ways to climb to the top.
            1. 1 step + 1 step + 1 step
            2. 1 step + 2 steps
            3. 2 steps + 1 step
             

            Constraints:

            1 <= n <= 45

             */

            int n1 = 2;
            int r1 = Solution1.ClimbStairs(n1);


            int n2 = 2;
            int r2 = Solution1.ClimbStairs(n2);



        }
    }
}
