public class Solution {
    public class Node{
        public int x;
        public int y;
    }

    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<Node, double> queue = new ();

        for(int i = 0; i < points.Length; i++){
            Node node = new Node();
            int x = points[i][0];
            int y = points[i][1];
            double val = Math.Sqrt(x*x + y*y);

            node.x = x;
            node.y = y;

            queue.Enqueue(node, val);
        }

        int[][] res = new int[k][];
        int index = 0;
        while(index < k){
            Node top = queue.Dequeue();
            res[index] = new int[2];
            res[index][0] = top.x;
            res[index][1] = top.y;
            index++;
        }
        return res;
    }
}
