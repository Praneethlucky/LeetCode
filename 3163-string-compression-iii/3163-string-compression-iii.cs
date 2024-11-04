public class Solution {
    public string CompressedString(string word) {
        StringBuilder s = new StringBuilder();
        char prev = word[0];
        int count = 1;
        for(int c=1; c<word.Length; c++)
        {
            if(word[c] == prev)
            {
                if(count == 9)
                {
                    s.Append(count.ToString());
                    s.Append(prev);
                    count =0;
                    prev = word[c];
                }
                count++;
                
            }
            else
            {
                s.Append(count.ToString());
                s.Append(prev);
                count =0;
                prev = word[c];
                count++;
            }
        }
        s.Append(count.ToString());
        s.Append(prev);
        return s.ToString();
    }
}