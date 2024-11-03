public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length != goal.Length)
            return false;
        
        string ne = s+s;
        return ne.Contains(goal)?true:false;
    }
}