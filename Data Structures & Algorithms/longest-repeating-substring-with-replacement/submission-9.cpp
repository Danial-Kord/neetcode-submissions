class Solution {
public:
    int characterReplacement(string s, int k) {
        if(s.size() == 0)
            return 0;
        
        unordered_map<char, int> charCount;
        int windowSize = 0;
        int l = 0;
        int maxRepeat = 0;
        int result = 0;
        for (int i=0;i<s.size();i++){
            charCount[s[i]]++;
            windowSize =  i - l + 1;
            maxRepeat = 0;
            for(auto c : charCount){
                maxRepeat = max(maxRepeat, c.second);
            }
            if(windowSize - maxRepeat > k){
                windowSize--;
                charCount[s[l]]--;
                l++;

            }
            result = max(result, windowSize);
        }
        return result;
    }
};
