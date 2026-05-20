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
            int area = Math.Abs((r-l)*(Math.Min(heights[l], heights[r])));

            int areall = Math.Abs((l - maxHeightLIndex) * Math.Min(heights[l], maxHeightL));
            int arearr = Math.Abs((r - maxHeightRIndex) * Math.Min(heights[r], maxHeightR));
            int max1 = Math.Max(areall, arearr);

            int arealr = Math.Abs((maxHeightRIndex - l) * Math.Min(heights[l], maxHeightR));
            int arearl = Math.Abs((maxHeightLIndex - r) * Math.Min(heights[r], maxHeightL));
            int max2 = Math.Max(arealr, arearl);

            maxArea = Math.Max(Math.Max(max1, max2), Math.Max(area, maxArea));


            if(heights[r] > maxHeightR){
                maxHeightR = heights[r];
                maxHeightRIndex = r;
            }
            if(heights[l] > maxHeightL){
                maxHeightL = heights[l];
                maxHeightLIndex = l;
            }
            
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
