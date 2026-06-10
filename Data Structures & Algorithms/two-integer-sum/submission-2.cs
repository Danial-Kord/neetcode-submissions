public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        for(int i = 0; i < nums.Length; i++){
            int v1 = nums[i];
            for(int j =i+1; j < nums.Length; j++){
                if(v1 + nums[j] == target){
                    res[0] = i;
                    res[1] = j;
                    return res;
                }
                     
            }
        }
        return res;
    }
}
