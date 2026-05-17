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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum = 0;
        int n1 = 0;
        int m1 = 1;
        int n2 = 0;
        int m2 = 1;

        bool flag = true;
        while(flag){
            flag = false;
            if(l1 != null){
                n1 += l1.val * m1;
                m1*=10;
                l1 = l1.next;
                flag = true;
            }
            if(l2 != null){
                n2 += l2.val * m2;
                m2*=10;
                l2 = l2.next;
                flag = true;
            }
        }

        sum = n1 + n2;
        ListNode head = new ListNode(0, null);
        ListNode cur = head;
        do{
            int mod = sum % 10;
            cur.next = new ListNode(mod,null);
            cur = cur.next;
            sum /= 10;
        }while(sum != 0);
        return head.next;

    }
}
