public class LRUCache {
    public class Node{
        public Node next;
        public Node previous;
        public int val;
        public int key;
    }
    Node tail;
    Node head;

    Dictionary<int, Node> map;
    int cap;
    public LRUCache(int capacity) {
        tail = null;
        head = null;
        cap = capacity;
        map = new ();
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)){
            UpdateMSU(map[key]);
            return map[key].val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(map.ContainsKey(key)){
           Node old = map[key];
           old.val = value;
           UpdateMSU(old); 
        }
        else{
            if(map.Count >= cap){
                RemoveLSU();
            }
            map[key] = NewNode(key, value);
        }
    }



    private void UpdateMSU(Node justUsed){
        Console.WriteLine(justUsed.key);
        Console.WriteLine(tail.key);

        if(tail != null && justUsed == tail && justUsed != head){
            if(tail.next == null){
                return;
            }
            tail = tail.next;
            tail.previous = null;
            Node temp = head;
            head = justUsed;
            if(tail.next == null){
                tail.next = head;
                head.previous = tail;
            }
            else{
                temp.next = head;
                head.previous = temp;
            }
            head.next = null;
            return;
        }
        else if(head != null && justUsed == head)
            return;
        
        Console.WriteLine(justUsed.key + "*");

        Node last = justUsed.previous;
        Node next = justUsed.next;
        last.next = next;
        next.previous = last;

        head.next = justUsed;
        justUsed.next = null;
        justUsed.previous = head;
        head = justUsed;
    }

    private Node NewNode(int key, int val){
        Node newNode = new Node();
        newNode.val = val;
        newNode.key = key;

        if(tail == null){
            tail = newNode;
        }
        else if(tail.next == null){
            head = newNode;
            head.previous = tail;
            tail.next = head;
        }
        else{
            newNode.previous = head;
            head.next = newNode;
            head = newNode;
        }
        return newNode;
    }


    private void RemoveLSU(){
        Node lsu = tail;

        if(lsu.next != null){
            tail = lsu.next;

            tail.previous = null;
            if(tail == head){
                head = null;
                tail.next = null;
            }
        }
        map.Remove(lsu.key);
    }
}
