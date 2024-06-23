public class Solution {
    public int FirstUniqChar(string s) {
        
        int[] alp = new int[26];
        var x = Encoding.ASCII.GetBytes(s);
        
        for(int i=0;i<x.Length; i++)
        {
            alp[x[i]-97]++;
        }
        for(int i=0;i<x.Length;i++)
        {
            if(alp[x[i]-97] == 1)
                return i;
        }
        return -1;
    }
}