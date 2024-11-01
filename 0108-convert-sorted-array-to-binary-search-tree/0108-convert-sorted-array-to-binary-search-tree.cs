/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length == 0)
            return null;
        return Helper(nums,0, nums.Length-1);
    }
    public TreeNode Helper(int[] nums, int low, int high)
    {
        if(high<low)
            return null;
        int mid = (low+high)/2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = Helper(nums,low, mid-1);        
        node.right = Helper(nums, mid+1, high);
        return node;

    }
}