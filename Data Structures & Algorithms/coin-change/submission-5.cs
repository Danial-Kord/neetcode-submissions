public class Solution {
    Dictionary<int, int> dp;
    int[] coins;
    public int CoinChange(int[] coins, int amount) {
        this.coins = coins;
        this.dp = new ();
        return rec(amount);
    }


    public int rec(int remain){
        if(remain < 0)
            return -1;
        if(remain == 0)
            return 0;
        if(dp.ContainsKey(remain))
            return dp[remain];
        int total = int.MaxValue;
        for(int i = 0; i < coins.Length; i++){
            if(remain - coins[i] >= 0){
                int val = rec(remain - coins[i]);
                if(val != -1)
                    total = Math.Min(val, total);
            }
        }
        if(total == int.MaxValue){
            dp[remain] = -1;
            return -1;
        }
        dp[remain] = 1 + total;
        return 1 + total;
    }
}
