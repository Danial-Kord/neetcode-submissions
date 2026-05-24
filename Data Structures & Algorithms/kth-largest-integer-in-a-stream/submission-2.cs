public class KthLargest {

    List<int> bst;
    int k;
    public KthLargest(int k, int[] nums) {
        Array.Sort(nums);
        this.k = k;
        bst = new (nums);
    }
    
    public int Add(int val) {
        if(bst.Count == 0){
            bst.Add(val);
            return val;
        }
        int l = 0;
        int r = bst.Count-1;
        int middle = r/2;
        while(l < r){
            middle = (l+r) / 2;
            if(val < bst[middle]){
                r = middle-1;
            }
            else if(val > bst[middle]){
                l = middle + 1;
            }
            else
                break;
        }
        middle = (r+l)/2;
        if(bst[middle] < val)
            bst.Insert(middle+1, val);
        else
            bst.Insert(middle, val);
        foreach (var t in bst){
            Console.Write(t+",");
        }
        Console.WriteLine();
        return bst[bst.Count - k];
    }
}
