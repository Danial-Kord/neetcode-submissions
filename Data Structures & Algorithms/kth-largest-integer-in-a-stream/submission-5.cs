public class KthLargest {

    PriorityQueue<int,int> minHeap;
    int k;
    public KthLargest(int k, int[] nums) {
        Array.Sort(nums);
        this.k = k;
        minHeap = new ();
        foreach (int i in nums)
            minHeap.Enqueue(i, i);
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        while(minHeap.Count > k){
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }
}
