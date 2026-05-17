public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] results = new int[k];
        HashSet<int> resultSet = new HashSet<int>();
        Dictionary<int, int> valueToCount = new Dictionary<int, int> ();
        int uniqueValues = 0;
        for (int i=0; i<nums.Length; i++){
            int value = nums[i];
            int count = 1;
            if(valueToCount.ContainsKey(value)){
                count = valueToCount[value];
                count += 1;
                valueToCount[value] = count;
            }
            else{
                uniqueValues += 1;
                valueToCount.Add(value, count);
                if(uniqueValues <= k){
                    results[uniqueValues-1] = value;
                    resultSet.Add(value);
                    continue;
                }
            }
            if(resultSet.Contains(value))
                continue;
            for (int j=0; j<k; j++){
                if(valueToCount[results[j]] < count){
                    resultSet.Remove(results[j]);
                    results[j] = value;
                    resultSet.Add(value);
                    break;
                }
            }
            
        }

        return results;

    }
}
