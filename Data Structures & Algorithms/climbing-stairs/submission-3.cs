public class Solution {

    int[] dp;

    public int calc(int cur, int n, int val){
        if(cur > n)
            return 0;
        if(cur == n){
            return val+1;
        }
        if(dp[cur] != 0)
            return dp[cur];
        int newVal = calc(cur+1,n,val) + calc(cur+2,n,val);
        dp[cur] = newVal; 
        return newVal;
    }

    public int ClimbStairs(int n) {     
        dp = new int[n];
        return calc(0,n,0);
    }
}
