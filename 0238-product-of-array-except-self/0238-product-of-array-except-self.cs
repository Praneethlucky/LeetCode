public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int l = nums.Length;
        int []p = new int[l];
        int []s = new int[l];
        
        p[0] = 1;
        s[l-1] =1;
        
        for(int i=1;i<l;i++)
        {
            p[i] = p[i-1]*nums[i-1];
        }
        for(int i=l-2;i>=0;i--)
        {
            s[i]=s[i+1]*nums[i+1];
                        Console.WriteLine(s[i]);

        }
        
        int []ou = new int[l];
        for(int i=0;i<l;i++)
        {
            ou[i] = p[i]*s[i];
        }
        return ou;
    }
}