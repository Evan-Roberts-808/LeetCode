# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def findMode(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        if not root:
            return []

        def inorder(root, count_dict):
            if not root:
                return
            
            inorder(root.left, count_dict)
            count_dict[root.val] = count_dict.get(root.val, 0) + 1
            inorder(root.right, count_dict)

        count_dict = {}
        inorder(root, count_dict)
        max_freq = max(count_dict.values())
        modes = [key for key, val in count_dict.items() if val == max_freq]

        return modes

