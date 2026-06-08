public class Solution {
    int[] max;
    int[] nums;
    public int Rob(int[] nums) {
        max = new int[nums.Length];
        for(int i = 0; i < max.Length; i++){
            max[i] = -1;
        }
        this.nums = nums;
        return rec(nums.Length-1);
    }


    public int rec(int cur){
        if(cur < 0)
            return 0;
        if(max[cur] != -1)
            return max[cur];
        if(cur == 0){
            max[0] = nums[0];
            return nums[0];
        }
        int val = rec(cur - 1);
        int val2 = rec(cur-2) + nums[cur];
        max[cur] = Math.Max(val,val2);
        return max[cur];
    }
}
