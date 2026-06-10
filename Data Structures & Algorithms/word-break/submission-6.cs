public class Solution {
    Dictionary<string, bool> map;
    public bool WordBreak(string s, List<string> wordDict) {
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;
        for(int i = 1; i <= s.Length; i++){
            string cur = s[0..i];
            string rest = s[(i-1)..];
            Console.WriteLine(rest + " " + cur);
            foreach(string v in wordDict){
                if(dp[i - 1] && rest.StartsWith(v)){
                    Console.WriteLine(i + " " + v);
                    Console.WriteLine(i+v.Length - 1);
                    dp[i + v.Length-1] = true;
                }
            }
        }
        return dp[dp.Length-1];
    }
}

