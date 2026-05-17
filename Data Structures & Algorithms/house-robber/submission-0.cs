public class Solution {

    public int DoRob(int[] bestRob, int[] nums, int cur, int len){
        if(cur >= len){
            return 0;
        }
        if(bestRob[cur] != -1){
            return bestRob[cur];
        }
        else if(cur >= len - 2)
            return nums[cur];

        int[] temp = new int[len - cur - 1];
        int max = -1;
        for (int i = 0; i < temp.Length; i++){
            temp[i] = DoRob(bestRob, nums, cur + 2 + i, len);
            if(max == -1){
                max = temp[i];
            }
            else if(max < temp[i]){
                max = temp[i];
            }
        }
        bestRob[cur] = nums[cur] + max;
        return bestRob[cur];

    }

    
    public int Rob(int[] nums) {
        int len = nums.Length;
        int[] bestRob = new int[len];
        Array.Fill(bestRob, -1);
        int v1 = DoRob(bestRob, nums, 0, len);
        int v2 = DoRob(bestRob, nums, 1, len);
        if(v1 < v2)
        return v2;
        return v1;
    }
}
