/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start

using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Reflection;


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode start;
        ListNode startPointer;
        ListNode pointer1;
        ListNode pointer2;
        bool carry;
        int sum;

        (sum, carry) = Adder(l1.val, l2.val, false);

        start = new ListNode(sum, null);
        startPointer = start;
        pointer1 = l1;
        pointer2 = l2;

        while (pointer1.next != null || pointer2.next != null)  
        {

            if (pointer1.next != null)
            {
                pointer1 = pointer1.next;
            }
            else
            {
                pointer1.val = 0;
            }
            if (pointer2.next != null)
            {
                pointer2 = pointer2.next;
            }
            else
            {
                pointer2.val = 0;
            }
            
            
            (sum, carry) = Adder(pointer1.val, pointer2.val, carry);

            startPointer.next = new ListNode(sum, null);
            startPointer = startPointer.next;

        }

        if (carry)
        {
            startPointer.next = new ListNode(1, null);
        }

        return start;
    }

    public (int, bool) Adder(int val1, int val2, bool carry)
    {
        int sum = val1 + val2;
        if (carry)
        {
            sum += 1;
        }
        if (sum > 9)
        {
            return (sum - 10, true);
        }
        else
        {
            return (sum, false);
        }
    }
}
// @lc code=end

