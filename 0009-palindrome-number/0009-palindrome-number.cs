public class Solution {
    public bool IsPalindrome(int x) {
        var s = x.ToString();
        if(s.Length<2) 
            return true;
        int i = 0;
        int j = s.Length-1;
        while(i<=j)
        {
            if(s[i] == s[j])
            {
                i++;
                j--;
                continue;
            }
            else
                return false;
        }
        return true;
    }
}