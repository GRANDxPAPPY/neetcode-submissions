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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode curr = dummyHead;
        while(l1 != null && l2 != null)
        {
            if(l1.val <= l2.val)
            {
                curr.next = l1;
                curr = curr.next;
                l1 = l1.next;
            }
            else
            {
                curr.next = l2;
                curr = curr.next;
                l2 = l2.next;
            }

        }
        if(l1 != null)
        {
            curr.next = l1;
            curr = curr.next;
            l1 = l1.next;
        }
        if(l2 != null)
        {
            curr.next = l2;
            curr = curr.next;
            l2 = l2.next;
        }
        return dummyHead.next;
    }
}