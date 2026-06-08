public class Solution {
    int res = 0;
    int [] fib;
    public int ClimbStairs(int n) {     
        fib = new int[n+1];
        return Fib(n);
    }



    public int Fib(int val){
        if(val < 0)
            return 0;
        if(fib[val] != 0)
            return fib[val];
        if(val <= 1){
            fib[val] = 1;
            return 1;
        }
        fib[val] = Fib(val-1) + Fib(val-2);
        return fib[val];
    }
}
