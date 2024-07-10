public class Solution {
    public int MinOperations(string[] logs) {
        int depth = 0;
        for(int i=0;i<logs.Length;i++)
        {            
            
            if(logs[i] == "../"){
                if(depth > 0)
                    depth -= 1;
            }
            else if(logs[i] == "./")
                depth = depth;
            else
                depth += 1;
        }
        return depth;
    }
}