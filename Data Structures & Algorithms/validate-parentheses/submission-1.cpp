class Solution {
public:
    bool isValid(string s) {
        unordered_map<char,int> charMap;
        charMap['('] = 1;
        charMap[')'] = -1;
        charMap['{'] = 2;
        charMap['}'] = -2;
        charMap['['] = 3;
        charMap[']'] = -3;
        
        stack<int> validChecker;

        for(int i=0; i < s.size(); i++){
            int encode = charMap[s[i]];
            if(!validChecker.empty() && validChecker.top() == -encode){
                validChecker.pop();
            }
            else{
                if(encode > 0)
                    validChecker.push(encode);
                else{
                    return false;
                }
            }
        }
        return validChecker.empty();
    }
};
