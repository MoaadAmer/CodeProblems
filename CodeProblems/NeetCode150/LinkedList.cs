using System;
using System.Collections.Generic;

namespace CodeProblems.NeetCode150
{
    public class LinkedList
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
        //206. Reverse Linked List
        //Easy
        //Given the head of a singly linked list, reverse the list, and return the reversed list.

        //Example 1 :
        //Input: head = [1, 2, 3, 4, 5]
        //Output: [5, 4, 3, 2, 1]

        //Example 2 :
        //Input: head = [1, 2]
        //Output: [2, 1]

        //Constraints:

        //The number of nodes in the list is the range[0, 5000].
        //-5000 <= Node.val <= 5000
        // Follow up: A linked list can be reversed either iteratively or recursively.Could you implement both?

        //Solution 1. iterative way.
        //Runtime O(N)
        //Space O(1)
        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode previous = null;
            while (current != null)
            {
                ListNode next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            return previous;
        }

        //Solution . recursive way.
        //Runtime O(N)
        //Space O(N)

        public ListNode ReverseListR(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode newHead = ReverseListR(head.next);
            head.next.next = head;
            head.next = null;
            return newHead;
        }
    }
}
