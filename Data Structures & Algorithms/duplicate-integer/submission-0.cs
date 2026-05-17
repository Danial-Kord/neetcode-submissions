public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> a = new HashSet<int>();
        for (int i =0; i<nums.Length; i++){
            if(a.Contains(nums[i])){
                return true;
            }
            a.Add(nums[i]);
        }
        return false;
    }
}
