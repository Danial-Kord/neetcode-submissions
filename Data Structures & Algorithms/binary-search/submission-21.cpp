class Solution {
public:
    int search(vector<int>& nums, int target) {
        int curIndex = nums.size() / 2;
        int newIndex = 0;
        int up = nums.size();
        int buttom = 0;
        while(curIndex >= buttom && curIndex <= up){
            if(target > nums[curIndex]){
                buttom = curIndex;
                newIndex = (curIndex + up) / 2;
            }
            else if (target < nums[curIndex]){
                up = curIndex+1;
                newIndex = (curIndex) / 2;
            }
            else{
                return curIndex;
            }
            std::cout << curIndex << "," << newIndex << "," << buttom << "," << up << endl;

            if(newIndex == curIndex || newIndex == buttom || newIndex == up){
                curIndex = newIndex;
                break;
            }
            
            curIndex = newIndex;
        }
        if(curIndex < 0 || curIndex > nums.size() || nums[curIndex] != target){
            return -1;
        }
        return curIndex;
    }
};
