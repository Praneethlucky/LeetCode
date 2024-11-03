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
    public bool IsSymmetric(TreeNode root) {
        return IsSymmetricHelp(root.left, root.right);
    }
    public bool IsSymmetricHelp(TreeNode l, TreeNode r)
    {
        if(l == null || r == null)
            return l==r;
        if(l.val != r.val)
            return false;
        return IsSymmetricHelp(l.left,r.right) && IsSymmetricHelp(l.right, r.left);
    }
}