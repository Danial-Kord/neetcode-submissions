public class Solution {
    Dictionary<char, string> map; 
    string digits;
    public List<string> LetterCombinations(string digits) {
        if(digits == null || digits == "")
            return new List<string>();
        map = new ();
        this.digits = digits;
        map['2'] = "abc";
        map['3'] = "edf";
        map['4'] = "ghi";
        map['5'] = "jkl";
        map['6'] = "mno";
        map['7'] = "pqrs";
        map['8'] = "tuv";
        map['9'] = "wxyz";
        List<string> res = new ();
        Dfs(0, res,"");
        return res;
    }


    public void Dfs(int index, List<string> res, string combination){
        if(index >= digits.Length){
            res.Add(combination);
            return;
        }

        string cur = map[digits[index]];
        for(int i = 0; i < cur.Length; i++){
            Dfs(index + 1, res, combination + cur[i]);
        }
    }

}
