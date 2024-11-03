public class Solution {
    public bool IsCircularSentence(string sentence) {
        var wo = sentence.Split(" ");
        string first = wo[0];
        char f = ' ';
        char l = ' ';
        
        foreach(var w in wo)
        {
           
            if( f ==' ')
            {
                f = first[0];
                l = first[first.Length-1];
                continue;
            }
            Console.WriteLine(f +" "+l);
            Console.WriteLine(w[0] +" "+f);
            if(w[0] == l)
            {
                l = w[w.Length-1];
                f = w[0];
            }
            else
                return false;
        }
        if(l == first[0])
            return true;
        return false;
    }
}