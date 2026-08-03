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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummyNode = new ListNode(0);
        dummyNode.next = head;
        ListNode slow = dummyNode;
        ListNode fast = dummyNode.next;
        int i = 0;
        while(n > 0)
        {
            
            fast = fast.next;
            n--;
        }
        while(fast != null)
        {
            fast =fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        
        return dummyNode.next;

        

    }
}
