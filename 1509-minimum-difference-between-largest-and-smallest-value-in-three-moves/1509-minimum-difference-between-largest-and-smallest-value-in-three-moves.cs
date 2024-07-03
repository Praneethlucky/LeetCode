public class Solution {
    public int MinDifference(int[] nums) {
        Array.Sort(nums);
        int n= nums.Length;
        List<int> mind = new List<int>();

        if(n>3)
        {
            int x = nums[n-4] - nums[0];
            int y = nums[n-3] - nums[1];
            int z = nums[n-2] - nums[2];
            int c = nums[n-1] - nums[3];
            mind.Add(x);
            mind.Add(y);
            mind.Add(z);
            mind.Add(c);
}
        else return 0;
        
        return mind.Min();

}
}