class Solution {
public:
    int trap(vector<int>& height) {
        int lastColLen = 0;
        int sum = 0;
        int lastValidColIndex = height.size()-1;

        for (int i = height.size() - 1; i > 1; i--){
            if(height[i] < height[i-1])
                continue;
            lastValidColIndex = i;
            break;
        }


        for(int i=0; i< height.size(); i++){
            if(lastColLen <= height[i]){
                lastColLen = height[i];
                continue;
            }
            else if (lastColLen > height[i]){
                int sumTemp = 0;
                int validSumTemp = 0;
                int biggestNextColIndex = i;
                int biggestNextCol = height[i];
                bool isFound = false;
                for(int j =i; j < height.size(); j++){
                    if(lastColLen <= height[j]){
                        validSumTemp = sumTemp;
                        i = j;
                        lastColLen = height[j];
                        isFound = true;
                        break;
                    }
                    else{
                        sumTemp += lastColLen - height[j];
                        if(biggestNextCol <= height[j]){
                            biggestNextColIndex = j;
                            biggestNextCol = height[j];
                            validSumTemp = sumTemp - (lastColLen - biggestNextCol) * (j-i+1);
                        }
                    }
                }
            
                sum += validSumTemp;
                if(!isFound)
                    i = biggestNextColIndex;
            }
        }
        return sum;
    }
};
