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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null)
        {
            return false;
        }
        if (root.left == null && root.right == null)
        {
            return targetSum == root.val;
        }
        bool leftHasPath = this.HasPathSum(root.left, targetSum - root.val);
        bool rightHasPath = this.HasPathSum(root.right, targetSum - root.val);
        
        return leftHasPath || rightHasPath;
    }
}