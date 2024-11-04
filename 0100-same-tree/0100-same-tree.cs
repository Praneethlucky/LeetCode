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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return Helper(p,q);
    }
    public bool Helper(TreeNode p, TreeNode q)
    {
        if((p == null && q != null) || (p != null && q == null))
            return false;
        if(p == null && q == null)
            return p==q;
        if(p.val != q.val)
            return false;
        return Helper(p.left, q.left) && Helper(p.right,q.right);
    }
}