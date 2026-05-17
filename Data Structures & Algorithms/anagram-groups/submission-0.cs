public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> answers = new List<List<string>>();
        List<HashSet<char>> sets = new List<HashSet<char>>();
        Dictionary<int, List<int>> ascciSet = new Dictionary<int, List<int>>();
        List<int> wordPlace = new List<int>();
        for (int i=0; i< strs.Length; i++){
            string cur = strs[i];
            int ascci = 0;
            char[] characters = cur.ToCharArray();
            sets.Add(new HashSet<char>());
            for (int j=0; j< characters.Length; j++){
                ascci += (int)(characters[j]);
                sets[i].Add(characters[j]);
            }
            if(!ascciSet.ContainsKey(ascci)){
                List<int> newWords = new List<int>();
                newWords.Add(i);
                ascciSet.Add(ascci,newWords);
                wordPlace.Add(answers.Count);
                answers.Add(new List<string>());
                answers[answers.Count-1].Add(cur);
            }
            else{
                List<int> wordsToCompare = ascciSet[ascci];
                bool found = false;
                foreach (int curIndex in wordsToCompare){
                    if(strs[curIndex].Length != cur.Length){
                        continue;
                    }
                    bool isSimilar = true;
                    HashSet<char> words1 = sets[curIndex];
                    HashSet<char> words2 = sets[i];
                    foreach(var w in words1){
                        if(!words2.Contains(w)){
                        isSimilar = false;
                        break;
                        }
                    }
                    
                    if(isSimilar){
                        answers[wordPlace[curIndex]].Add(cur);
                        wordPlace.Add(wordPlace[curIndex]);
                        found = true;
                        break;
                    }
                }
                if(!found){
                    ascciSet[ascci].Add(i);
                    wordPlace.Add(answers.Count);
                    answers.Add(new List<string>());
                    answers[answers.Count-1].Add(cur);
                }
            }
        }
        return answers;
    }

}
