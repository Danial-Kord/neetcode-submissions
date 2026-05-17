class Solution {
public:
    int findMin(vector<int> &nums) {
        int min = nums[0];

        int l = 0;
        int r = nums.size()-1;
        // if(nums [l] < nums[i])
        //     return nums[l];
        int middle = 0;
        while(l <= r){
            middle = l + (r - l + 1) / 2;
            // Debug.Log(r + " " + l);
            if(nums[l] > nums[middle]){
                r = middle - 1;
                if(nums[middle] < min)
                    min = nums[middle];
            }
            else{
                if(nums[l] < min)
                    min = nums[l];
                l = middle + 1;
            }
            
        }
        return min;
    }
};
