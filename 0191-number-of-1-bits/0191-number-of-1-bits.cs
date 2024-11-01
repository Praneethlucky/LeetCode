public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        int res = n;
        while(res>0)
        {
            int x = res%2;
            res = res/2;
            if(x != 0)
                count++;
        }
        return count;
    }
}