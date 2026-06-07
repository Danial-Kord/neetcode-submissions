public class Solution {
    int[][] grid;
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        this.grid = grid;
        for(int i = 0; i < this.grid.Length; i++){
            for(int j = 0; j < this.grid[i].Length; j++){
                if(this.grid[i][j] == 1){
                    maxArea = Math.Max(Bfs(i,j), maxArea);
                }
            }
        }
        return maxArea;
    }


    public int Bfs(int X, int Y){
        Console.WriteLine(X +" " + Y);
        int area = 1;

        Queue<(int x, int y)> queue = new ();

        queue.Enqueue((X,Y));
        grid[X][Y] = 0;
        while(queue.Count != 0){
            (int x, int y) top = queue.Dequeue();
            int x = top.x;
            int y = top.y;
            if(x+1 < grid.Length){
                if(grid[x+1][y] == 1){
                    queue.Enqueue((x+1, y));
                    grid[x+1][y] = 0;
                    area++;
                }
            }
            if(x-1 >= 0){
                if(grid[x-1][y] == 1){
                    queue.Enqueue((x-1, y));
                    grid[x-1][y] = 0;
                    area++;
                }
            }

            if(y+1 < grid[0].Length){
                if(grid[x][y+1] == 1){
                    queue.Enqueue((x, y+1));
                    grid[x][y+1] = 0;
                    area++;
                }
            }
            if(y-1 >= 0){
                if(grid[x][y-1] == 1){
                    queue.Enqueue((x, y-1));
                    grid[x][y-1] = 0;
                    area++;
                }
            }

        }
        Console.WriteLine(area);
        return area;

    }
}
