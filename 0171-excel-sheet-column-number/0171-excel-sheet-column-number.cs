public class Solution {
    public int TitleToNumber(string columnTitle) {
        int output = 0;
        foreach(var c in columnTitle)
        {
            if(output !=0)
            {
                output = (output*26)+((int)c - 64);
            }
            else{
                output = (int)c -64;
            }
        }
        return (output);
    }
}