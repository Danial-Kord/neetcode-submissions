public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        HashSet<string> foundedTouples = new HashSet<string>();
        List<List<int>> res = new List<List<int>>();

        for(int i=0; i<nums.Length; i++){
            int num = nums[i];
            int target = 0 - num;

            HashSet<int> currentSearch = new HashSet<int>();
            for(int j=0; j<nums.Length; j++){
                if(j == i)
                    continue;
                if(currentSearch.Contains(target - nums[j])){
                    int min = target - nums[j];
                    int max = nums[j];
                    int middle = num;
                    if(min > middle){
                        int temp = min;
                        min = middle;
                        middle = temp;
                    }
                    if(min > max){
                        int temp = min;
                        min = max;
                        max = temp;
                    }
                    if(middle > max){
                        int temp = middle;
                        middle = max;
                        max = temp;
                    }
                    string key = "" + min + "" + middle + "" + max;
                    if(foundedTouples.Contains(key)){
                        continue;
                    }
                    foundedTouples.Add(key);
                    res.Add(new List<int>(){min,middle,max});
                }
                currentSearch.Add(nums[j]);
                
            }
        }
        return res;
    }
}
