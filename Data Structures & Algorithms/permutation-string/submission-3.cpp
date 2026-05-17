class Solution {
public:
    bool checkInclusion(string s1, string s2) {
        if(s1.size() == 0 || s2.size() == 0)
            return false; // Cause it is breaking the condition of both being more than size 1

        int l = 0;
        unordered_map<char, int>lookupMap;
        for(int i = 0; i < s1.size(); i++){
            lookupMap[s1[i]]++;
        }

        unordered_map<char, int>windowMap;

        for (int r = 0; r < s2.size(); r++){
            windowMap[s2[r]]++;
            if(lookupMap.find(s2[r]) != lookupMap.end()){
                if(lookupMap[s2[r]] >= windowMap[s2[r]]){
                    if(r-l+1 == s1.size())
                        return true;
                }
                else{
                    for (int i = l; i < r; i++){
                        windowMap[s2[i]]--;
                        if(s2[i] == s2[r]){
                            l = i + 1;
                            break;
                        }
                    }
                }
            }
            else{
                windowMap.clear();
                l = r + 1;
            }
        }


        return false;
    }
};
