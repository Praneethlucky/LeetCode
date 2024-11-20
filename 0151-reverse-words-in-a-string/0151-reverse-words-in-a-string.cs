public class Solution {
    public string ReverseWords(string s) {
        int i=0;
        int j=0;
        StringBuilder ou = new StringBuilder();
        for(int x=0;x<s.Length;x++)
        {
            if(s[x] == ' ')
            {
                i++;
            }
            else
            {
                break;
            }
               
            
        }
             
        for(int x=0;x<s.Length;x++)
        {
            if(s[s.Length-1 -x] == ' ')
            {
                j++;
            }
            else
            {
                break;
            }
        }
        string d= s.Substring(i,s.Length-i-j);
        List<string> o = new List<string>();
        StringBuilder listb = new StringBuilder();
        char prev = '-';
        for(int x=0;x<d.Length;x++)
        {
            if(d[x]==' ')
            {
                if(prev != ' ')
                {
                    o.Add(listb.ToString());
                    listb = new StringBuilder();
                }
                prev = ' ';
            }
            else
            {
                prev = d[x];
                listb.Append(d[x]);
            }
        }
        o.Add(listb.ToString());
        
        for(int l=o.Count-1;l>=0 ; l--)
        {
            if(!o[l].Contains(" ")){
                Console.WriteLine(o[l]);
                ou.Append(o[l]);
                ou.Append(" ");
            }

        }
        string output = ou.ToString();
        return output.Substring(0,output.Length-1);
    }
}