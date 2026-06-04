public class Solution {
    List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        res = new ();
        HashSet<int> set = new (nums);

        Dfs(new List<int>(), set);

        return res;
    }

    public void Dfs(List<int> cur, HashSet<int> candidates){
        if(candidates.Count == 0){
            return;
        }
        foreach(int c in candidates){
            HashSet<int> newSet = new HashSet<int>(candidates);
            newSet.Remove(c);
            List<int> newList = new List<int>(cur);
            newList.Add(c);
            if(newSet.Count != 0){
                Dfs(newList, newSet);
            }
            else{
                res.Add(newList);
            }
        }
    }
}
