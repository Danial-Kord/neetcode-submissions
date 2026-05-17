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
    public void ReorderList(ListNode head) {
        List<ListNode> vals = new List<ListNode>();
        ListNode root = head;
        while(head != null){
            vals.Add(head);
            head = head.next;
        }
        head = root;
        int l = 0;
        int r = vals.Count - 1;
        ListNode last = head;
        while(l < r){
            last.next = vals[l];
            vals[l].next = vals[r];
            last = vals[r];
            l++;
            r--;
        }
        if(l == r){
            last.next = vals[r];
            last = last.next;
        }
        last.next = null;
    }
}
