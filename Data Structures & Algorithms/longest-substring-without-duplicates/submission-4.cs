public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        int r = 0;
        Dictionary<char, int> charToIndex = new Dictionary<char, int>();
        int maxLen = 0;
        while(r < s.Length){
            if(charToIndex.ContainsKey(s[r])){
                int mustRemoveTillIndex = charToIndex[s[r]];
                while(l<=mustRemoveTillIndex){
                    charToIndex.Remove(s[l]);
                    l++;
                }
            }
            charToIndex[s[r]] = r;
            maxLen = Math.Max(maxLen, charToIndex.Count);
            r++;
        }
        return maxLen;
    }
}
