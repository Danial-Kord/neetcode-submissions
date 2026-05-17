public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        for (int i=0; i< strs.Count(); i++){
                char encodeLen = (char)(strs[i].Length);
                encoded += encodeLen;
                encoded += strs[i];
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        char[] characters = s.ToCharArray();
        List<string> res = new List<string>();

        for(int i=0; i<characters.Length; i++){
            int length = (int)(characters[i]);
            string newStr = "";
            for(int j=0; j<length; j++){
                newStr += characters[i + 1 + j];
            }
            res.Add(newStr);
            i+=length;
        }
        return res;
   }
}
