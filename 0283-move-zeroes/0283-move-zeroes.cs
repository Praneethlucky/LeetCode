public class Solution {
    public void MoveZeroes(int[] nums) {
        int inpo = 0;
        
        foreach(var num in nums)
        {
            if(num != 0)
                nums[inpo++] = num;
        }
        while(inpo < nums.Length)
            nums[inpo++] = 0;
    }
}