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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

        for(int i=0;i<lists.Length;i++){
            minHeap.Enqueue(lists[i], lists[i].val);
        }

        ListNode root = new ListNode(0, null);
        ListNode tail = root;

        while(minHeap.Count != 0){
            ListNode min = minHeap.Dequeue();
            if(min.next != null){
                minHeap.Enqueue(min.next, min.next.val);
            }
            ListNode newNode = new ListNode(min.val,null);
            tail.next = newNode;
            tail = tail.next;
        }
        return root.next;

    }
}
