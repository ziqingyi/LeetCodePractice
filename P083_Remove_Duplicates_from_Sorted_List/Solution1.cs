using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P083_Remove_Duplicates_from_Sorted_List
{
    public static class Solution1
    {
        /*
         *Runtime: 96 ms, faster than 67.46% of C# online submissions .
         * Memory Usage: 26.7 MB, less than 13.29% of C# online submissions.
         *
         */
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }


    }
}
