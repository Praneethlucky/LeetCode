public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxC = 0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[i].Length;j++)
            {
                if(grid[i][j] == 1)
                {
                    maxC = Math.Max(maxC, MaxArea(grid,i,j,0));
                }           
            }
        }
        return maxC;
    }
    
    public int MaxArea(int[][] grid, int i, int j, int count)
    {
        if(i>=0 && i<grid.Length && j<grid[0].Length &&j>=0)
        {
            if(grid[i][j] == 1)
            {
                grid[i][j] = 0;
                return 1+MaxArea(grid,i,j-1,count)
                +MaxArea(grid,i+1,j,count)
                +MaxArea(grid,i-1,j,count)
                +MaxArea(grid,i,j+1,count);
            }
        }
        
        return 0;
    }
}