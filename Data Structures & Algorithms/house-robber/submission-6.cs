public class Solution {

    public int DoRob(int[] bestRob, int[] nums, int cur, int len){
        if(cur >= len){
            return 0;
        }
        if(bestRob[cur] != -1){
            return bestRob[cur];
        }

        int[] temp = new int[len - cur - 2];
        int max = DoRob(bestRob, nums, cur + 2, len);
        for (int i = 1; i < temp.Length; i++){
            temp[i] = DoRob(bestRob, nums, cur + 2 + i, len);
            if(max < temp[i]){
                max = temp[i];
            }
        }
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
