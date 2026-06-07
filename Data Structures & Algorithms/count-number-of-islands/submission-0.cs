public class Solution {
    int islands = 0;
    char[][] grid;
    public int NumIslands(char[][] grid) {
        this.grid = grid;
        for(int i=0; i < grid.Length; i++){
            for(int j=0; j < grid[i].Length; j++){
                if(this.grid[i][j] == '1'){
                    Console.WriteLine(i +" " + j);
                    islands++;
                    Dfs(i,j);
                }
            }
        }
        return islands;

    }


    public void Dfs(int x, int y){
        grid[x][y] = '0';
        if(y+1 < grid[0].Length)
            if(grid[x][y+1] == '1')
                Dfs(x,y+1);
        if(x+1 < grid.Length)
            if(grid[x+1][y] == '1')
                Dfs(x + 1,y);   
        if(x-1 >= 0)
            if(grid[x-1][y] == '1')
                Dfs(x - 1,y);   
        if(y-1 >= 0)
            if(grid[x][y-1] == '1')
                Dfs(x,y-1);   
    }

}
