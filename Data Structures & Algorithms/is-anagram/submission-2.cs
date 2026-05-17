public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> res = new Dictionary<char, int>();
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();
        if(s1.Length != t1.Length)
            return false;

        for (int i=0; i< s1.Length; i++){
            res.TryGetValue(s1[i], out int val);
            res[s1[i]] = val+1;
        }
        for (int i=0; i< t1.Length; i++){
            res.TryGetValue(t1[i], out int val);
            res[t1[i]] = val-1;
            if(val-1 < 0)
                return false;
        }
        return true;
    }
}
