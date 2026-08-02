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
    public bool HasCycle(ListNode head) {
        
       
        ListNode curr = head;
        ListNode right = curr;
        
        while(right != null && right.next != null)
        {
            curr =curr.next;
            
            right = right.next.next;
            if(curr == right)
            {
                return true;
            }
        }
        return false;

    }
}
