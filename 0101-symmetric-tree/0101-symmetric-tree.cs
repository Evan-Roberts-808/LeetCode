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
        bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
              {
                return left == right;
              }
            return left.val == right.val && IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        }
        return IsMirror(root, root);
    }
}