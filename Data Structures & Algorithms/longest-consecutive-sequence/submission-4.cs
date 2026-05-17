public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int,int> startToPointer = new Dictionary<int,int>();
        Dictionary<int,int> pointerToStart = new Dictionary<int,int>();
        Dictionary<int,int> pointerToCount = new Dictionary<int,int>();
        
        int max = 0;
        if(nums.Length != 0)
            max = 1;
        
        for (int i=0; i<nums.Length; i++){
            int value = nums[i];
            if(pointerToCount.ContainsKey(value)){
                int count = pointerToCount[value] + 1;
                int startIndex = pointerToStart[value];
                int pointer = value+1;
                pointerToCount.Remove(value);
                pointerToStart.Remove(value);

                if(pointerToCount.ContainsKey(value + 1)){
                    int count2 = pointerToCount[value + 1];
                    if(count2 < count){
                        pointerToCount[value + 1] = count;
                        pointerToStart[value + 1] = startIndex;
                        startToPointer[startIndex] = value + 1;
                    }
                }
                else{
                    pointerToCount.Add(value+1, count);
                    pointerToStart.Add(value+1, startIndex);   
                    startToPointer[startIndex] = value + 1;
                }

                bool update = true;

                while(startToPointer.ContainsKey(pointer)){
                    int sequence2Start = pointer;
                    int newPointer = startToPointer[sequence2Start];
                    count = pointerToCount[pointer] + pointerToCount[newPointer];
                    pointerToCount[newPointer] = count;
                    pointerToStart[newPointer] = startIndex;
                    startToPointer[startIndex] = newPointer;

                    startToPointer.Remove(sequence2Start);
                    pointerToCount.Remove(pointer);
                    pointerToStart.Remove(pointer);
                    
                    pointer = newPointer;
                }
                
                if(count > max)
                    max = count;

            }
            else{
                if(startToPointer.ContainsKey(value+1)){
                    int pointer = startToPointer[value+1];
                    int count = pointerToCount[pointer] + 1;

                    startToPointer.Remove(value+1);
                    if(startToPointer.ContainsKey(value)){
                        int pointer2 = startToPointer[value];
                        int count2 = pointerToCount[pointer2];
                        if(count2 < count){
                            startToPointer[value] = pointer;
                            pointerToCount[pointer] = count;
                            pointerToStart[pointer] = value;

                            startToPointer.Remove(value);
                            pointerToCount.Remove(pointer2);
                            pointerToStart.Remove(pointer2);
                        }
                        else{
                            pointerToCount.Remove(pointer);
                            pointerToStart.Remove(pointer);
                        }

                    }
                    else{
                        startToPointer.Add(value,pointer);
                        pointerToCount[pointer] = count;
                        pointerToStart[pointer] = value;
                    }

                    int tempPointer = value;
                    while(pointerToCount.ContainsKey(tempPointer)){
                        int sequence2Start = pointerToStart[pointer];
                        count = pointerToCount[pointer] + pointerToCount[tempPointer];
                        pointerToCount[pointer] = count;
                        pointerToStart[pointer] = sequence2Start;
                        startToPointer[sequence2Start] = pointer;

                        startToPointer.Remove(tempPointer);
                        pointerToCount.Remove(tempPointer);
                        pointerToStart.Remove(tempPointer);
                        
                        tempPointer = sequence2Start;
                    }


                    if(count > max)
                        max = count;

                }
                else{
                    if(!startToPointer.ContainsKey(value) && !pointerToCount.ContainsKey(value+1)){
                        pointerToCount.Add(value+1, 1);
                        pointerToStart.Add(value+1, value);
                        startToPointer.Add(value, value+1);
                    }
                }

            }
        }
        return max;
    }
}
