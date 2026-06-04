public class Solution {
    List<int> nums;
    int target;
    List<List<int>> res;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        this.nums = new List<int>(nums);
        this.target = target;
        res = new ();
        Dfs(0, new List<int>(), 0);
        return res;
    }


    public void Dfs(int index, List<int> subset, int sum){
        if(index >= nums.Count)
            return;
        Dfs(index+1, new List<int>(subset), sum);
        
        if(sum + nums[index] == target){
            subset.Add(nums[index]);
            res.Add(subset);
            return;
        }
        else{
            if(sum + nums[index] < target){
                List<int> newList = new List<int>(subset);
                newList.Add(nums[index]);
                Dfs(index, newList, sum + nums[index]);
            }
        }
    }
}
