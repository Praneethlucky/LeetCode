public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> count = new Dictionary<char,int>();
        
        foreach(char c in s)
        {
            if(count.ContainsKey(c))
            {
                count[c] += 1;
            }
            else
            {
                count[c] = 1;
            }
        }
        foreach(char c in t)
        {
            if(count.ContainsKey(c))
            {
                count[c] -= 1;
            }
            else
            {
                return false;
            }
        }
        foreach(var c in count)
        {
            if(c.Value !=0)
                return false;
        }
        return true;
    }
}