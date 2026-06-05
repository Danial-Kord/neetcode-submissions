public class Solution {
    string word;
    char[][] board;
    public bool Exist(char[][] board, string word) {
        this.word = word;
        this.board = board;
        HashSet<(int x, int y)> set = new();
        for(int i=0; i < board.Length; i++){
            for(int j = 0; j < board[i].Length; j++){
                if(board[i][j] == word[0]){
                    if(Dfs(i, j, new HashSet<(int x, int y)>(), 1))
                        return true;
                }
            }
        }
        return false;
    }


    public bool Dfs(int x, int y, HashSet<(int x, int y)> set, int index){
        Console.Write("-" + x + " " + y + " " + board[x][y]);

        if(index >= word.Length){
            return true;
        }
        set.Add((x,y));
        bool result = false;
        if(x + 1 < board.Length){
            if(board[x+1][y] == word[index] && !set.Contains((x+1, y))){
                result = result || Dfs(x+1, y, new HashSet<(int x, int y)> (set), index+1);
            }
        }
        if(x - 1 >= 0){
            if(board[x-1][y] == word[index] && !set.Contains((x-1, y))){
                result = result || Dfs(x-1, y, new HashSet<(int x, int y)> (set), index+1);
            }
        }

        if(y + 1 < board[0].Length){
            if(board[x][y+1] == word[index] && !set.Contains((x, y+1))){
                result = result || Dfs(x, y+1, new HashSet<(int x, int y)> (set), index+1);
            }
        }
        if(y - 1 >= 0){
            if(board[x][y - 1] == word[index] && !set.Contains((x, y-1))){
                result = result || Dfs(x, y-1, new HashSet<(int x, int y)> (set), index+1);
            }
        }
        return result;
    }

}
