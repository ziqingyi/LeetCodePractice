using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P083_Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Given the head of a sorted linked list,
             *delete all duplicates such that each element appears only once.
             *Return the linked list sorted as well.
             *
             * The number of nodes in the list is in the range [0, 300].
             * -100 <= Node.val <= 100
             * The list is guaranteed to be sorted in ascending order.
             */

            ListNode n5 = new ListNode(3, null);
            ListNode n4 = new ListNode(3, n5);
            ListNode n3 = new ListNode(2,n4);
            ListNode n2 = new ListNode(1,n3);
            ListNode head = new ListNode(1,n2);

            ListNode newHead = Solution1.DeleteDuplicates(head);



        }
    }


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
