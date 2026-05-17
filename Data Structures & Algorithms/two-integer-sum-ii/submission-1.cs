public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        HashSet<int> seenNumbers = new HashSet<int>();
        Dictionary<int,int> numToPlace = new Dictionary<int,int>();

        for(int i=0; i< numbers.Length; i++){
            int newNum = numbers[i];
            if(seenNumbers.Contains(newNum)){
                continue;
            }
            if(seenNumbers.Contains(target - newNum)){
                int[] res = new int[]{numToPlace[target - newNum],i+1};
                return res;
            }
            seenNumbers.Add(newNum);
            numToPlace.Add(newNum,i+1);
        }
        return new int[2];
    }
}
