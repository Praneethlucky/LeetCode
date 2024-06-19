public class Solution {
    public int ClimbStairs(int n) 
    {
        if(n == 1)
            return 1;
        int preStep = 1;
        int curStep = 1;
        int total = 0;
        for(int i=1; i<n; i++){
            total = preStep + curStep;
            preStep = curStep;
            curStep = total;
        }
        return total;
    }
    
}