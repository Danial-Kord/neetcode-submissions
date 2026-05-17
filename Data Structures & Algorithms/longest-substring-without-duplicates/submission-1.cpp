class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int maxSequence = 0;
        string window = "";
        unordered_set<char> window_set;
        for (int i = 0; i < s.size(); i++){
            if(window_set.find(s[i]) != window_set.end()){
                for(int j=0;j<window.size();j++){
                    if (window[j] == s[i]){
                        if(j+1 < s.size()){
                            window = window.substr(j+1);
                        }
                        else {
                            window = "";
                        }
                        window += s[i];
                        window_set.clear();
                        for (char c : window) {
                            window_set.insert(c);
                        }
                        break;
                    }
                }
            }
            else{
                window += s[i];
                window_set.insert(s[i]);
                maxSequence = max(maxSequence, (int)window.size());
            }
        }
        return maxSequence;
    }
};
