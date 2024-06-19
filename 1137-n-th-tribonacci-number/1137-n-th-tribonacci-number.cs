public class Solution {
    public int Tribonacci(int n) {
        if(n == 0)
            return 0;
        if(n == 1)
            return 1;
        if(n == 2)
            return 1;
        int preStep = 0;
        int curStep = 1;
        int nexStep = 1;
        int total = 0;
        for(int i=2; i<n; i++){
            total = preStep + curStep + nexStep;
            preStep = curStep;
            curStep = nexStep;
            nexStep = total;
        }
        return total;
    }
}