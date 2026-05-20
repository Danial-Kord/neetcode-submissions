public class Solution {
    public int MaxArea(int[] heights) {
        int maxHeightL = 0;
        int maxHeightR = 0;
        int l = 0;
        int r = heights.Length - 1;
        int maxHeightRIndex = r;
        int maxHeightLIndex = l;

        int maxArea = 0;
        while(l < r){
            int area = (r-l)*(Math.Min(heights[l], heights[r]));

            maxArea = Math.Max(area, maxArea);

            if(heights[l] < heights[r]){
                l++;
            }
            else{
                r--;
            }
        }
        return maxArea;
    }
}
