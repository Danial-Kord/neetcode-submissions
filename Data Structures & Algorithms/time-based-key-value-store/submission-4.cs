public class TimeMap {
    Dictionary<String, List<Tuple<int, String>>> dict;

    public TimeMap() {
        dict = new Dictionary<String, List<Tuple<int, String>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(dict.ContainsKey(key)){
            List<Tuple<int, String>> list = dict[key];
            list.Add(new Tuple<int, String>(timestamp, value));
        }
        else{
            List<Tuple<int, String>> list = new List<Tuple<int, String>>();
            Tuple<int, String> pair = new Tuple<int, String>(timestamp,value);
            list.Add(pair);
            dict.Add(key,list);
        }
    }
    
    public string Get(string key, int timestamp) {
        if(!dict.ContainsKey(key))
            return "";
        List<Tuple<int, String>> list = dict[key];
        if(list.Count == 0)
            return "";
        int l = 0;
        int r = list.Count -1;
        int middle;
        var pair = list[0];
        while(l <= r){
            middle = l + (r - l + 1) / 2;
            if(list[middle].Item1 > timestamp){
                r = middle - 1;
            }
            else if(list[middle].Item1 < timestamp){
                l = middle + 1;
                pair = list[middle];
            }
            else{
                return list[middle].Item2;
            }
        }
        if(pair.Item1 < timestamp)
            return pair.Item2;
        return "";
    }
}
