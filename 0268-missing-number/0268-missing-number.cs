public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = 0;
        int max = -1;
        int isZero = -1;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 0)
                isZero = 0;
            if(max < nums[i])
            {
                max = nums[i];
            }
            sum += nums[i];
        }
        int x = (max * (max + 1))/2;
        if(isZero == -1)
            return 0;
        return x - sum == 0? max + 1: x-sum;
    }
}