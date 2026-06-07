/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null)
            return null;
        HashSet<(int i, int j)> seenEdge = new ();

        Dictionary<int, Node> map = new ();
        Node root = new Node(node.val);
        map[node.val] = root;

        Queue<Node> bfs = new ();
        bfs.Enqueue(node);
        while(bfs.Count != 0){
            Node top = bfs.Dequeue();
            int val = top.val;
            foreach(Node n in top.neighbors){
                if(map.ContainsKey(n.val)){
                    if(!seenEdge.Contains((n.val, val))){
                        map[n.val].neighbors.Add(map[val]);
                        map[val].neighbors.Add(map[n.val]);
                        seenEdge.Add((val, n.val));
                        seenEdge.Add((n.val, val));
                    }
                }
                else{
                    Node newNode = new Node(n.val);
                    newNode.neighbors.Add(map[val]);
                    map[val].neighbors.Add(newNode);
                    map[n.val] = newNode;
                    
                    seenEdge.Add((val, n.val));
                    seenEdge.Add((n.val, val));
                    bfs.Enqueue(n);
                }
            }
        }
        return root;
    }
}
