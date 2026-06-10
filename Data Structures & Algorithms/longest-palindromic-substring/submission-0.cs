public class Solution {
    public string s;
    public string LongestPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;

        int  maxL = 0;
        int  maxR = 0;
        
        this.s = s;

        while(l != s.Length){
            r = s.Length - 1;            
            while(r >= l && (r-l > maxR - maxL)){
                bool check = IsPalindrome(l, r);
                if(check && (maxR - maxL) < r-l){
                     maxR = r;
                     maxL = l;
                }
                r--;
            }
            l++;
        }
        Console.WriteLine(maxL + " " + maxR);
        return s[maxL..(maxR+1)];
    }


    public bool IsPalindrome(int l, int r){

        while(l <= r){
            if(s[l] != s[r]){
                return false;
            }
            r--;
            l++;
        }        
        return true;
    }

}
