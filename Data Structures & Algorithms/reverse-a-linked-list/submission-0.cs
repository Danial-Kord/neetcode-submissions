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
        Stack<int> stack = new Stack<int>();
        while(head != null){
            stack.Push(head.val);
            head = head.next;
        }
        if(stack.Count == 0)
            return null;
        
        ListNode res = new ListNode(stack.Pop(),null);
        ListNode cur = res;
        while(stack.Count != 0){
            int val = stack.Pop();
            ListNode newNode = new ListNode(val,null);
            cur.next = newNode;
            cur = newNode;
        }
        return res;

    }
}
