public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        Queue<(int index, List<int> cur)> queue = new (); //value, position

        List<List<int>> res = new();
        res.Add(new List<int>());
        for(int i = 0; i < nums.Length; i++){
            queue.Enqueue((i, new List<int>(){nums[i]}));
        }
        while(queue.Count != 0){
            (int index, List<int> cur) = queue.Dequeue();
            for(int i = index+1; i < nums.Length; i++){
                List<int> newList = new List<int>(cur);
                newList.Add(nums[i]);
                queue.Enqueue((i, newList));
            }
            res.Add(cur);
        }
        return res;
    }
}
