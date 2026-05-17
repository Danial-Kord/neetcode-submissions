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
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode root = null;
        while(head != null){
            stack.Push(head);
            head = head.next;
        }
        ListNode after = null;
        for(int i = 0; i < n-1; i++){
            after = stack.Pop();
            root = after;
        }
        
        ListNode removeNode = stack.Pop();
        if(stack.Count != 0){
            ListNode before = stack.Pop();
            before.next = after;
            root = before;
        }
        while(stack.Count != 0){
            root = stack.Pop();
        }
        return root;
    }
}
