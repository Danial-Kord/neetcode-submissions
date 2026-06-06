public class Solution {
    public List<List<string>> res;
    public string s;
    public List<List<string>> Partition(string s) {
        res= new ();
        this.s = s;
        Dfs(0, new List<string>(), "");
        return res;
    }


    public void Dfs(int index, List<string> vals, string cur){
        if(index == s.Length){
            if(cur != "")
                vals.Add(cur);
            for(int i =0; i < vals.Count; i++){
                if(!IsPalindrome(vals[i]))
                    return;
            }
            res.Add(vals);
         return;   
        }
        cur = cur + s[index];
        Dfs(index + 1, new List<string>(vals), cur);
        if(index == s.Length-1)
            return;
        List<string> newList = new List<string>(vals);
        newList.Add(cur);
        Dfs(index + 1, newList, "");
    }



    public bool IsPalindrome(string t){
        if(t.Length == 1)
            return true;
        int l = 0;
        int r = t.Length-1;
        while(l <= r){
            if(t[l] != t[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
