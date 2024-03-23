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
  public int GetMinimumDifference(TreeNode root) {
    int minDiff = int.MaxValue;
    int prevVal = int.MinValue;

    void InOrder(TreeNode node) {
      if (node == null) return;

      InOrder(node.left);

      if (prevVal != int.MinValue) {
        minDiff = Math.Min(minDiff, Math.Abs(node.val - prevVal));
      }

      prevVal = node.val;

      InOrder(node.right);
    }

    InOrder(root);
    return minDiff;
  }
}