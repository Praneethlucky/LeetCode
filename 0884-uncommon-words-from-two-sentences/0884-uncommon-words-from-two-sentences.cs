public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        string[] s1s = s1.Split(' ');
        string[] s2s = s2.Split(' ');
        Dictionary<string,int> count = new Dictionary<string,int>();
        List<string> output = new List<string>();
        
        foreach(string s in s1s)
        {
            if(count.ContainsKey(s))
                count[s]++;
            else
                count.Add(s,1);
        }
        foreach(string s in s2s)
        {
            if(count.ContainsKey(s))
                count[s]++;
            else
                count.Add(s,1);
        }
        foreach(KeyValuePair<string, int> kvp in count )
        {
            if(kvp.Value == 1)
                output.Add(kvp.Key);
        }
        return output.ToArray();

    }
}