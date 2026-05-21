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
    public ListNode ReverseKGroup(ListNode head, int k) {
        Stack<ListNode> stack = new Stack<ListNode>();
        int counter = 0;
        ListNode curHead = head;
        ListNode curTail = head;
        ListNode root = new ListNode(0, null);
        ListNode lastHead = head;

        while(true){
            counter = 0;
            ListNode tail = head;
            ListNode lastTail = tail;
            while(counter < k){
                if(tail != null){
                    stack.Push(tail);
                }
                else{
                    lastHead.next = head;
                    return root.next;
                }
                Console.WriteLine(tail.val);
                lastTail = tail;
                tail = tail.next;
                counter++;

            }

            curTail = tail;
            ListNode last = stack.Peek();
            ListNode temp = last;

            while(stack.Count != 0){
                stack.Pop();
                if(stack.Count == 0)
                    break;
                ListNode now = stack.Peek();
                last.next = now;
                last = now;
            }
            
            if(root.next == null)
                root.next = temp;
            else{
                lastHead.next = temp;
            }
            if(curTail != null){
                head = curTail;
                last.next = lastHead;
                lastHead = last;
            }
            else{
                last.next = null;
                break;
            }
        }
        return root.next;
        
    }
}
