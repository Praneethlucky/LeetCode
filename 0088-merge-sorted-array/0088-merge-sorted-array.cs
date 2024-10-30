public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i=m;
        foreach(int nu in nums2)
        {
            nums1[i++] = nu;
        }
        Array.Sort(nums1);
    }
}