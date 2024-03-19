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
    public int CountNodes(TreeNode root) {
        if (root == null)
        {
            return 0;
        }
        if(root.left == null && root.right == null)
        {
            return 1;
        }
        int left = this.CountNodes(root.left);
        int right = this.CountNodes(root.right);
        
        return left + right + 1;
    }
}