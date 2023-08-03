# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def isSymmetric(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        def isMirror(left, right):
            if not left and not right: return True  # If both left and right are None, it means both subtrees are empty, and hence they are considered mirrors of each other, so it returns True.

            if not left or not right: return False  #If either left or right is None, but not both, it means only one subtree is empty, and they can't be mirrors of each other, so it returns False.

            if left.val != right.val: return False #If the values of left and right nodes are not equal, it means they are not mirrors of each other, so it returns False.

            return isMirror(left.left, right.right) and isMirror(left.right, right.left) #If the values of left and right nodes are equal, it recursively checks if the left subtree of left is a mirror of the right subtree of right and vice versa. This is done by calling the isMirror function with left.left and right.right and also with left.right and right.left. The function returns the logical AND of these two recursive calls, which means both subtrees must be mirrors of each other for the entire tree to be symmetric.

        return isMirror(root, root) #Finally, the isSymmetric function calls the isMirror function with the root node of the binary tree twice, once for the left subtree and once for the right subtree. If both subtrees are mirrors of each other, the binary tree is symmetric, so it returns True. Otherwise, it returns False.
