public class KthLargest {

    PriorityQueue<int,int> minHeap;
    int k;
    public KthLargest(int k, int[] nums) {
        Array.Sort(nums);
        this.k = k;
        minHeap = new ();
        foreach (int i in nums)
            minHeap.Enqueue(i, -i);
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, -val);
        int index = 1;
        Stack<int> stack = new ();
        while(index < k){
            stack.Push(minHeap.Dequeue());
            index++;
        }
        int res = minHeap.Peek();
        while(stack.Count != 0){
            int pop = stack.Pop();
            minHeap.Enqueue(pop, -pop);
        }
        return res;
    }
}
