public class Solution {

    public string Encode(IList<string> strs) {
        string res = "";
        for(int i = 0; i< strs.Count; i++){
            res += "$";
            res += "" + strs[i].Length;
            res += "$";
            res += strs[i];
        }
        return res;
        
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        char[] chars = s.ToCharArray();
        for(int i =0; i < s.Length; i++){
            string cur = ""+ chars[i];
            string num = "";
            if(cur.Equals("$")){
            Console.WriteLine(cur);

                i++;
                //TODO check
                cur = ""+chars[i];
                while(!cur.Equals("$")){
                    num +=  cur;
                    i++;
                    cur = ""+chars[i];
                }
                i++;
            }
            else{
                continue;
            }
            Console.WriteLine(num);
            int strLen = int.Parse(num);
            string found = "";
            for(int j=i;j<i+strLen;j++){
                found += chars[j];
            }
            result.Add(found);
            i+=strLen-1;
        }
        return result;
   }
}
