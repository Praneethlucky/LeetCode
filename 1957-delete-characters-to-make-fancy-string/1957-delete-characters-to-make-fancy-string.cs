public class Solution {
    public string MakeFancyString(string s) {
        char lasAl = s[0];
        StringBuilder sb = new StringBuilder();
        sb.Append(s[0]);
        int count =0;
        for(int i=1;i<s.Length; i++)
        {
            if(lasAl == s[i])
            {
                count++;
                if(count == 2)
                {
                    count--;
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            else
            {
                count =0;
                sb.Append(s[i]);
            }
            lasAl = s[i];

        }
        return sb.ToString();
    }
}