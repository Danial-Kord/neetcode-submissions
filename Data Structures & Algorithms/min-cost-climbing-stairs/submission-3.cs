public class Solution {

    private int BestFrom(int[] cost,int [] bestC, int cur, int len){
        if(cur >= len)
            return 0;
        if(bestC[cur] != -1){
            return bestC[cur];
        }
        bestC[cur] = cost[cur] + Math.Min(
            BestFrom(cost, bestC, cur+1, len), 
                 BestFrom(cost, bestC, cur+2, len));
        return bestC[cur];
    }

    public int MinCostClimbingStairs(int[] cost) {
        int len = cost.Length;
        int[] bestC = new int[len];
        Array.Fill(bestC, -1);
        int v1 = BestFrom(cost, bestC,0,len);
        int v2 = BestFrom(cost, bestC,1,len);
        if(v1 < v2)
        return v1;
        return v2;
    }
}
