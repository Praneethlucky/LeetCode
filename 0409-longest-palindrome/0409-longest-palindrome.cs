public class Solution {
    public int LongestPalindrome(string s) {
        int count = 0;
        if(s.Length  == 1)
            return 1;
        Dictionary<char,int> dic = new Dictionary<char,int>();
        foreach(var sd in s)
        {
            if(dic.ContainsKey(sd)){
                dic.Remove(sd);
                count++;
            }
            
            else
                dic[sd] = 1;
        }
        return dic.Count>0 ?count*2 + 1: count*2;
        
    }
}