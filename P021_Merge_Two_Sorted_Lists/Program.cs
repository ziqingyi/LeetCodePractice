using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P021_Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merge two sorted linked lists and return it as a new sorted list.
             * The new list should be made by splicing together the nodes of the first two lists.
             
              Input: l1 = [1,2,4], l2 = [1,3,4]
              Output: [1,1,2,3,4,4]
             
             Example 2:

                Input: l1 = [], l2 = []
                Output: []
                Example 3:

                Input: l1 = [], l2 = [0]
                Output: [0]
                 

                Constraints:

                The number of nodes in both lists is in the range [0, 50].
                -100 <= Node.val <= 100
                Both l1 and l2 are sorted in non-decreasing order.
             */

            ListNode a1 = new ListNode(1,null);
            ListNode a2 = new ListNode(2,null);
            ListNode a3 = new ListNode(4, null);
            a1.next = a2;
            a2.next = a3;

            ListNode b1 = new ListNode(1, null);
            ListNode b2 = new ListNode(3, null);
            ListNode b3 = new ListNode(4, null);
            b1.next = b2;
            b2.next = b3;

            ListNode result1 = Solution1.MergeTwoLists(a1, b1);




        }
    }
}
