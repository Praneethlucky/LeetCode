public class Solution {
    public string ReverseVowels(string s) {
     
        List<char> voewls = ['a','e','i','o','u','A','E','I','O','U'];
        int low = 0;
        int high = s.Length-1;
        StringBuilder result = new StringBuilder(s);
        while(low<high)
        {
            if(voewls.Contains(s[low]))
            {
                if(voewls.Contains(s[high]))
                {
                    char temp = result[high];
                    result[high] = result[low];
                    result[low] = temp;
                    low++;
                    high--;
                }
                else{
                    high--;
                }
            }
            else{
                low++;
            }
        }
        return result.ToString();
        
    }
}