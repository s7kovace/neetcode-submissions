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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null){
            ListNode temp = curr.next; // Node 2
            curr.next = prev; //The next value of the link list points to curr
            prev = curr; // Update previous to point to curr (new relative prev point)
            curr = temp; // Now current is pointing to the new current node which is node 2.
        }

        return prev;
    }
}
