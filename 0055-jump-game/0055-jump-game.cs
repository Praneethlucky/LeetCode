public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length -1;
        for(int i = n-1; i>=0 ; i--)
        {
            if(i+nums[i] >= n)
                n=i;
        }
        return n>0?false:true;
    }
}