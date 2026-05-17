public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> valueToIndex = new Dictionary<int, int>();
        HashSet<int> pairSet = new HashSet<int>();

        for (int i=0; i < nums.Length; i++){

            if(!valueToIndex.ContainsKey(nums[i])){
                valueToIndex[nums[i]] = i;
            }
            if(pairSet.Contains(nums[i])){
                return new int[]{valueToIndex[target - nums[i]],i};
            }
            pairSet.Add(target - nums[i]);
        }

        return new int[0];
        
    }
}
