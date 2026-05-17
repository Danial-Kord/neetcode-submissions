public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if(piles.Length < 1)
            return -1;
        int maxVal = piles[0];
        int minVal = piles[0];

        for(int i = 1; i < piles.Length; i++){
            if(piles[i] > maxVal){
                maxVal = piles[i];
            }
            if(piles[i] < minVal){
                minVal = piles[i];
            }
        }

        Console.WriteLine("Max value: " + maxVal);

        int rate = maxVal;
        int res = piles.Length;
        if(res > h)
            return -1; // it is not possible
        Console.WriteLine("Res: " + res);

        // int l=minVal,r=(h/piles.Length) + 1;
        int l=1;
        int r= maxVal;

        int middle = 0;
        int output = maxVal;
        while(l <= r){
            res = 0;
            middle = l + (r - l + 1) / 2;
            Console.WriteLine("middle: " + middle);

            for(int i = 0; i < piles.Length; i++){
                res += piles[i] / middle;
                if(piles[i] % middle != 0){
                    res += 1;
                }
            }
            if(res <= h){
                if(middle < output)
                    output = middle;
                r = middle - 1;
            }
            else if (res > h){
                l = middle + 1;
            }
            
        }
        
        return output;
    }
}
