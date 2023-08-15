# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def hasPathSum(self, root, targetSum):
        """
        :type root: TreeNode
        :type targetSum: int
        :rtype: bool
        """
        if not root:
            return False #No nodes return false

        if not root.left and not root.right:
            return targetSum == root.val #if the root has no child nodes check if the root matches the target and return True or False accordingly

        left_has_path = self.hasPathSum(root.left, targetSum - root.val)
        right_has_path = self.hasPathSum(root.right, targetSum - root.val)

        return left_has_path or right_has_path

        