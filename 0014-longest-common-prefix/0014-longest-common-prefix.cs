public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        StringBuilder stringBuilder = new StringBuilder();

        Array.Sort(strs);
        int lastStr = strs.Length - 1;

        for (int i = 0; i < strs[0].Length; i++)
        {
            if (strs[0][i] == strs[lastStr][i])
                stringBuilder.Append(strs[0][i]);
            else
                break;
        }

        return stringBuilder.ToString();        
    }
}