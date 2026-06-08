public class Solution {
    int[] max;
    int[] max2;
    int[] nums;
    int[] nums2;
    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        max = new int[nums.Length];
        max2 = new int[nums.Length];
        this.nums2 = new int [nums.Length];
        this.nums = nums;

        for(int i = 0; i < max2.Length; i++){
            max[i] = -1;
            max2[i] = -1;
            nums2[i] = nums[i];
        }
        this.nums[0] = 0;
        this.nums2[nums2.Length - 1] = 0;

        int val1= rec(nums.Length-1);

        this.nums = nums2;
        this.max = max2;
        int val2= rec(nums.Length-1);

        return Math.Max(val1, val2);
    }


    public int rec(int cur){
        if(cur < 0){
            return 0;
        }
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
