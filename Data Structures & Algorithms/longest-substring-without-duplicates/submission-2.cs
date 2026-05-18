public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0;
        int r=0;
        int max = 0;
        HashSet<char> curSet = new HashSet<char>();
        char[] chars = s.ToCharArray();
        while(r < s.Length){
            if(curSet.Contains(chars[r])){
                curSet.Remove(chars[l]);
                l++;
                while(l<r && curSet.Contains(chars[r])){
                    curSet.Remove(chars[l]);
                    l++;
                }
            }
            curSet.Add(chars[r]);
            max = Math.Max(max, curSet.Count);
            r++;
        }
        return max;
    }
}
