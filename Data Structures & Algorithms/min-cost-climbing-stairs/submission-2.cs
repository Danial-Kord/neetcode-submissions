public class Solution {

    private int BestFrom(int[] cost,int [] bestC, int cur){
        if(cur >= cost.Length)
            return 0;
        if(bestC[cur] != -1){
            return bestC[cur];
        }
        int bestVal = BestFrom(cost, bestC, cur+1);
        int bestVal2 = BestFrom(cost, bestC, cur+2);
        if(bestVal2 < bestVal)
            bestVal = bestVal2;
        bestVal = bestVal + cost[cur];
        bestC[cur] = bestVal;
        return bestVal;
    }

    public int MinCostClimbingStairs(int[] cost) {
        int[] bestC = new int[cost.Length];
        for(int i=0; i < cost.Length; i++){
            bestC[i] = -1;
        }
        int v1 = BestFrom(cost, bestC,0);
        int v2 = BestFrom(cost, bestC,1);
        if(v1 < v2)
        return v1;
        return v2;
    }
}
