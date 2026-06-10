public class Solution {
    Dictionary<string, bool> map;
    public bool WordBreak(string s, List<string> wordDict) {
        map = new ();
        return Test(s, wordDict);
    }
    public bool Test(string cur,  List<string> wordDict){
    if(cur == "")
        return true;
    if(map.ContainsKey(cur))
        return map[cur];
    foreach(string s in wordDict){
        if(cur.StartsWith(s)){
            string str = cur[s.Length..];
            if(Test(str, wordDict)){
                map[cur + str] = true;
                return true;
            }
            else{
                map[cur + str] = false;
            }
            }
        }
        map[cur] = false;
        return false;
    }
}

