public class Solution {

    public int DoRob(int[] bestRob, int[] nums, int cur, int len){
        if(cur >= len){
            return 0;
        }
        if(bestRob[cur] != -1){
            return bestRob[cur];
        }

        int max = DoRob(bestRob, nums, cur + 2, len);
        int m2 = DoRob(bestRob, nums, cur + 3, len);
        if(m2 > max)
            max = m2; 
        bestRob[cur] = nums[cur] + max;
        return bestRob[cur];

    }

    
    public int Rob(int[] nums) {
        int len = nums.Length;
        if(len == 1)
            return nums[0];
        int[] bestRob = new int[len];
        Array.Fill(bestRob, -1);
        bestRob[len-1] = nums[len-1];
        bestRob[len-2] = nums[len-2];
        int v1 = DoRob(bestRob, nums, 0, len);
        int v2 = DoRob(bestRob, nums, 1, len);
        if(v1 < v2)
        return v2;
        return v1;
    }
}
