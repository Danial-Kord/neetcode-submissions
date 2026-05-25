public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> minHeap = new ();

        for(int i=0; i < stones.Length; i++){
            minHeap.Enqueue(stones[i], -stones[i]);
        }

        while(minHeap.Count > 1){
            int a = minHeap.Dequeue();
            int b = minHeap.Dequeue();
            int delta = Math.Abs(a-b);
            if(delta != 0){
                minHeap.Enqueue(delta, -delta);
            }
        }
        if(minHeap.Count == 0){
            return 0;
        }  
        return minHeap.Peek(); 

    }
}
