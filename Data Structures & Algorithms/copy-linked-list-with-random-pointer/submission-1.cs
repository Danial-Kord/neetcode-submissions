/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, int> placement = new Dictionary<Node, int>();
        Node cur = head;

        int index = 0;
        while(cur != null){
            placement[cur] = index;
            index++;
            cur = cur.next;
        }
        Dictionary<int, Node> newListPlace = new Dictionary<int, Node>();
        
        cur = head;
        Node newHead = new Node(-1);
        Node newCur = newHead;

        index = 0;
        while(cur != null){
            Node newNode = null;
            if(newListPlace.ContainsKey(index)){
                newNode = newListPlace[index];
            }
            else{
                newNode = new Node(cur.val);
                newListPlace[index] = newNode;
            }
            if(cur.random != null){
                int place = placement[cur.random];
                if(!newListPlace.ContainsKey(place)){
                    Node newRandom = new Node(cur.random.val);
                    newListPlace[place] = newRandom;
                }
                newNode.random = newListPlace[place];
            }
            newCur.next = newNode;
            newCur = newCur.next;
            index++;
            cur = cur.next;
        }
        newCur.next = null;
        return newHead.next;

    }
}
