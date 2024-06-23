public class Solution {
    public void ReverseString(char[] s) 
    {
        int mid = s.Length % 2 == 0 ? s.Length / 2 - 1 : s.Length / 2;
        for (int i = 0; i < s.Length; i++)
        {
            if (i <= mid)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}