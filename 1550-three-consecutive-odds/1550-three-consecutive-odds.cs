public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;
        foreach(var a in arr)
        {
            count = a%2==0?0:count+1;
            if(count == 3)
                return true;
            
        }
        return false;
    }
}