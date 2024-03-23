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
        return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
    }
    
    private TreeNode SortedArrayToBSTHelper(int[] nums, int low, int high)
    {
        if (low > high) return null;
        
        int mid = low + (high - low) / 2;
        
        TreeNode root = new TreeNode(nums[mid]);
        
        root.left = SortedArrayToBSTHelper(nums, low, mid - 1);
        root.right = SortedArrayToBSTHelper(nums, mid + 1, high);
        
        return root;
    }
}