class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        stack<int> stk;
        for(int i = 0; i < tokens.size(); i++){
            if(tokens[i] != "+" && tokens[i] != "-" &&
             tokens[i] != "*" && tokens[i] != "/"){
                int value = stoi(tokens[i]);
                stk.push(value);
            }
            else{
                char cur = tokens[i][0];
                int val1,val2,result;
                if(!stk.empty()){
                        val1 = stk.top();
                        stk.pop();
                }
                else{
                    return 0;
                }
                if(!stk.empty()){
                    val2 = stk.top();
                    stk.pop();
                }
                else{
                    return 0;
                }
                if(cur == '+'){
                    result = val1 + val2;
                }
                else if(cur == '-'){
                    result = val2 - val1;
                }
                else if(cur == '*'){
                    result = val1 * val2;
                }
                else if(cur == '/'){
                    result = val2 / val1;
                }
                stk.push(result);
            }
        }
        if(stk.empty()){
            return 0;
        }
        return stk.top();
    }
};
