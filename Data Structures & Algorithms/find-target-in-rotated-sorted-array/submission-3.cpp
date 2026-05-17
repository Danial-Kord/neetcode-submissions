class Solution {
public:
    int search(vector<int>& nums, int target) {
        int l = 0;
        int r = nums.size() - 1;

        int min = nums[0];
        int minIndex = 0;

        int middle;
        while(l <= r){
            middle = l + (r - l + 1) / 2;

            if(nums[middle] >= nums[l]){
                if(nums[l] < min){
                    minIndex = l;
                    min = nums[l];
                }
                l = middle + 1;

            }
            else{
                if(nums[middle] < min){
                    minIndex = middle;
                    min = nums[l];
                }
                r = middle - 1;

            }
        }
        std::cout << minIndex << endl;
        if(minIndex != 0){
            r = minIndex -1;
            l = minIndex - nums.size();
        }
        else{
            l = 0;
            r = nums.size() - 1;
        }
        while(l <= r){
            middle = l + (r - l + 1) / 2;
            if(middle < 0)
                middle = nums.size() + middle;

            if(nums[middle] > target){
                r = l + (r - l + 1) / 2 - 1;
            }
            else if(nums[middle] < target){
                l = l + (r - l + 1) / 2 + 1;
            }
            else{
                return middle;
            }
        }
        return -1;
    }
};
