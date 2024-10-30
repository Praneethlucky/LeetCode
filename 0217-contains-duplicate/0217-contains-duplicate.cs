public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        foreach(int num in nums.ToList())
        {
            if(count.ContainsKey(num))
            {
                return true;
            }
            count[num]= 1;
            
        }
        return false;
    }
}