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
        HashSet<ListNode> hashset = new HashSet<ListNode>();
        while(head != null){
            if(hashset.Contains(head)){
                return true;
            }
            hashset.Add(head);
            head = head.next;
        }
        return false;
    }
}
