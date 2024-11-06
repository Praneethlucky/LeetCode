public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int sl = word1.Length < word2.Length? word1.Length-1: word2.Length-1;
        int diff = Math.Abs(word1.Length - word2.Length);
        StringBuilder output = new StringBuilder();
        for(int i=0;i<=sl;i++){
            output.Append(word1[i]);
            output.Append(word2[i]);
        }
        if(word1.Length == word2.Length)
                    return output.ToString();

        if(word1.Length < word2.Length){
            Console.WriteLine(sl+" "+word2.Length);

            output.Append(word2.Substring(sl+1,diff));
        }
        else
            output.Append(word1.Substring(sl+1,diff));
        return output.ToString();
    }
}