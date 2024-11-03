public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] p = new int[nums.Length/2];
        int[] n = new int[nums.Length/2];
        int i=0;
        int j=0;
        foreach(var num in nums)
        {
            if(num>=0)
            {
                p[i] = num;
                i++;
            }
            else
            {
                n[j] = num;
                j++;
            }
        }
        i=0;
        j =0;
        int c =0;
        while(i<nums.Length/2)
        {
            nums[c] = p[i];
            c++;
            nums[c] = n[j];
            c++;
            i++;
            j++;
        }
        return nums;

    }
}