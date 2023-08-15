# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def countNodes(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root: #if root is None return 0 since there is no tree
            return 0
        
        if not root.left and not root.right: #if there are no child nodes return 1 as it is only the root
            return 1

        left_count = self.countNodes(root.left)
        right_count = self.countNodes(root.right)

        return left_count + right_count + 1