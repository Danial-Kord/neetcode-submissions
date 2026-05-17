class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        int r = 0;
        int l = matrix.size() * matrix[0].size() - 1;
        int rowLen = matrix[0].size();
        int middle = r + (l-r + 1) / 2;
        int cur = matrix[middle / rowLen][middle % rowLen];
        while(r <= l){
            middle = r + (l-r + 1) / 2;
            std::cout << middle / rowLen << endl;
            std::cout << middle % rowLen << endl;
            std::cout << r << "," << l << endl;
            std::cout << middle << endl;
            cur = matrix[middle / rowLen][middle % rowLen];

            std::cout << cur << endl;

            if(cur < target){
                r = middle + 1;
            }
            else if (cur > target){
                l = middle - 1;
            }
            else{
                return true;
            }
        }

        return false;
    }
};
