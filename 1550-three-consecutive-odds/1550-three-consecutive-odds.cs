public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;
        foreach(var a in arr)
        {
            if(a%2 == 0)
            {
                count =0;
                
            }
            else{
                count += 1;
                if(count == 3)
                    return true;
            }
            
        }
        return false;
    }
}