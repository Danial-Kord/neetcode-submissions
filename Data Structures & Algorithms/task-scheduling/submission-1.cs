public class Solution {

    public class Node{
        public char val;
        public int num;
        public int lastPlaced;
    }

    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<Node, int> minHeap = new ();
        Dictionary<char, Node> map = new ();
        foreach(char c in tasks){
            if(map.ContainsKey(c)){
                map[c].num++;
            }
            else{
                Node node = new Node();
                node.val = c;
                node.num = 1;
                node.lastPlaced = int.MinValue;
                map[c] = node;
            }
        }

        foreach(char c in map.Keys){
            Node n1 = map[c];
            minHeap.Enqueue(n1, -n1.num);
        }
        Stack<Node> stack = new();
        

        int res = 0;
        while(minHeap.Count != 0){
                Node node = minHeap.Peek();
                if(res+1 - n > node.lastPlaced){
                    res++;
                    minHeap.Dequeue();
                    node.lastPlaced = res;
                    node.num--;
                    if(node.num != 0)
                        minHeap.Enqueue(node, -node.num);
                    while(stack.Count != 0){
                        Node pop = stack.Pop();
                        if(pop.num > 0)
                            minHeap.Enqueue(pop, -pop.num);
                    }
                }
                else{
                    if(minHeap.Count != 0)
                        stack.Push(minHeap.Dequeue());
                    if (minHeap.Count == 0){
                        res++;
                        while(stack.Count != 0){
                            Node pop = stack.Pop();
                            if(pop.num > 0)
                                minHeap.Enqueue(pop, -pop.num);
                        }
                    }
                }
        }
        return res;

    }
}
