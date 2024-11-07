public class Solution {
    public int LargestCombination(int[] candidates) {
        int ans = 0;
        for (int i = 0; i < 32; i++) {
            int cnt = 0;
            foreach (int candidate in candidates) {
                if ((candidate & (1 << i)) != 0) cnt++;
            }
            ans = Math.Max(ans, cnt);
        }
        return ans;
    }
}