public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

        foreach (string curStr in strs){
            char[] chars = curStr.ToCharArray();
             SortedDictionary<char,int> map = new SortedDictionary<char, int>();
             for(int i=0; i< chars.Length; i++){
                if(map.ContainsKey(chars[i])){
                   map[chars[i]] += 1; 
                }
                else{
                    map[chars[i]] = 1;
                }
             }
             string final = "";
             foreach(var m in map.Keys){
                final += map[m];
                final+= m;
             }
             if(!list.ContainsKey(final)){
                list[final] = new List<string>();
             }
            list[final].Add(curStr);
        }
        List<List<string>> finalRes = new List<List<string>>();
        foreach (var s in list.Values)
            finalRes.Add(s);
        return finalRes;
    }
}
