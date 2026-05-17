public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] res = new int[nums.Length];
       
        int multiplier = 1;
        for (int i=0; i< nums.Length; i++){
            res[i] = 1;
            res[i] *= multiplier;
            multiplier *= nums[i];
        }
        multiplier = 1;
        for (int i=nums.Length-1; i>= 0; i--){
            res[i] *= multiplier;
            multiplier *= nums[i];
        }
        return res;
    }
}
