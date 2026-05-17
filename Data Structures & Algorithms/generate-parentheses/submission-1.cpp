class Solution {
public:
    void backtrack(int n, int left, int right, vector<string> &res, string cur) {
        string val = "";
        if(left < n){
            backtrack(n, left+1, right, res, cur + "(");
            if(left > right){
                backtrack(n, left, right+1, res, cur + ")");
            }
        }
        else if(left == n){
            if(right < n){
                backtrack(n, left, right+1, res, cur + ")");
            }
            else if(right == n){
                res.push_back(cur);
            }
        }
    }

public:
    vector<string> generateParenthesis(int n) {
        vector<string> res;
        backtrack(n,0,0,res,"");
        return res;
    }
};
