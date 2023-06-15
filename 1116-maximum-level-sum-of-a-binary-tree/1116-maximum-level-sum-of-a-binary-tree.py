# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def maxLevelSum(self, root):

        #this code takes a root parameter that represents the root node of a binary tree, 
        #if the root is none, indicating an empty tree, it returns 0
        if not root:
            return 0 

        #max_sum is set to negative infinity, which will be used to track the maximum sum encountered so far
        max_sum = float('-inf') 
        #max_level is initially set to 0, and it will store the level with the maximum sum
        max_level = 0
        #level is set to 1 representing the current level being processed
        level = 1
        #queue is initialized as a deque (a double-ended queue) containing the root node
        queue = deque([root])

        while queue:
            #set ti 0 at the beginning of each level to store the sum of node values at the current level
            level_sum = 0
            #set to current size of the queue, representing the number of nodes at the current level
            level_size = len(queue)

            #for loop iterates level_size, representing the number of nodes at the current level.
            for _ in range(level_size):
            #node is assigned the leftmost node in the queue using popleft() and its value is added to level_sum
                node = queue.popleft()
                level_sum += node.val
                #if the node has a left child it is added to the queue
                if node.left:
                    queue.append(node.left)
                #if the node has a right child it is also added to the queue
                if node.right:
                    queue.append(node.right)

            #after processing each level, the code checks if level_sum is greater than max_sum, 
            #if it is max_sum is updated and max_level is set to the current level
            if level_sum > max_sum:
                max_sum = level_sum
                max_level = level
            #the level variable is incremented to move to the next level
            level += 1
        #max_level value is returned
        return max_level