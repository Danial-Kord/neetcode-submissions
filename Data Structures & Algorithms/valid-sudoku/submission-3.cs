public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> rows = new List<HashSet<char>>(9);
        List<HashSet<char>> cols = new List<HashSet<char>>(9);
        List<HashSet<char>> slots = new List<HashSet<char>>(9);
         for(int i=0; i< 9; i++){
            rows.Add(new HashSet<char>()); 
            cols.Add(new HashSet<char>()); 
            slots.Add(new HashSet<char>()); 
         }
        for(int i=0; i< 9; i++){
            for(int j=0; j< 9; j++){
                if(board[i][j] == '.')
                continue;
                if(rows[i].Contains(board[i][j]) 
                || cols[j].Contains(board[i][j])
                || slots[(i/3)*3 + j/3].Contains(board[i][j])){
                    return false;
                }
                rows[i].Add(board[i][j]);
                cols[j].Add(board[i][j]);
                slots[(i/3)*3 + j/3].Add(board[i][j]);
            }    
        }

        return true;
    }
}
