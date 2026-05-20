public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        s = s.ToLower();
        //nums 48 - 57
        // A-Z 65-90
        //a-z 97-122
        l = FindFirstValid(0, s, +1);
        r = FindFirstValid(r, s, -1);
        while(l < r){
            if(s[l] != s[r])
                return false;
            l = FindFirstValid(l+1, s, +1);
            r = FindFirstValid(r - 1, s, -1);
        }
        return true;
    }

    public int FindFirstValid(int i, string s, int offset){
        int asci = s[i];
        while(!((asci >= 48 && asci <= 57) || (asci >= 65 && asci <= 90) || (asci >= 97 && asci <= 122))){
            if((i+offset < 0 || i+offset >= s.Length))
                break;
            i += offset;
            asci = s[i];
        }
        return i;
    }
    public int ToLowerAsci(char t){
        int asci = t;
        if(asci >= 97 && asci <= 122){
            return asci - 32;
        }
        return asci;
    }
}
