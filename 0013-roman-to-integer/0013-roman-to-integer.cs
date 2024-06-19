public class Solution {
    public int RomanToInt(string s) {
        var arr = new Dictionary<char, int>();
arr.Add('I', 1);
arr.Add('V', 5);
arr.Add('X', 10);
arr.Add('L', 50);
arr.Add('C', 100);
arr.Add('D', 500);
arr.Add('M', 1000);
int result = arr[s[s.Length - 1]];
for (int i = s.Length - 1; i > 0; i--)
{
    if (i > 0)
    {
        if (arr[s[i]] > arr[s[i - 1]])
        {
            result = result - (arr[s[i - 1]]);
        }
        else
        {
            result = result + (arr[s[i - 1]]);
        }
    }
    else
    {
        if (arr[s[i]] > arr[s[i + 1]])
        {
            result = result + (arr[s[i - 1]]);
        }
        else
        {
            result = result - (arr[s[i - 1]]);
        }
    }
}
        return result;
    }
}