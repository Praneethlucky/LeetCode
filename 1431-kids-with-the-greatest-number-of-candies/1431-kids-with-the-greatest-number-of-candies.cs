public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> outw =  new List<bool>();
        
        int max = candies.Max();
        
        foreach(var c in candies)
        {
            if((c+extraCandies)>=max)
                outw.Add(true);
            else
                outw.Add(false);
        }
        return outw;
        
    }
}