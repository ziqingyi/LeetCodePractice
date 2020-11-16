using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P021_Merge_Two_Sorted_Lists
{

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

    public class Solution1
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            ListNode mergedList = null;

            if (l1.val < l2.val)
            {
                mergedList = l1;
                mergedList.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                mergedList = l2;
                mergedList.next = MergeTwoLists(l1, l2.next);
            }

            return mergedList;
        }



    }
}
