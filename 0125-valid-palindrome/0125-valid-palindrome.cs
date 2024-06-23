public class Solution {
    public bool IsPalindrome(string s) {
        
        s = s.ToLower();
        byte[] sb = Encoding.ASCII.GetBytes(s);
        
        int low = 0;
        int high = sb.Length-1;
        
        while(low <= high)
        {
            if ((sb[low] > 96 && sb[low] < 123) || (sb[low] > 47 && sb[low] < 58))
            {
                if ((sb[high] > 96 && sb[high] < 123) || (sb[high] > 47 && sb[high] < 58))
                {
                    if(sb[low] != sb[high])
                    {
                        return false;
                    }
                    high--;
                    low++;
                }
                else
                {
                    high--;
                }
            }
            else
            {
                low++;
            }
        }
        return true;

    }
}