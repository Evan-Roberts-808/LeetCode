class Solution(object):
    def productExceptSelf(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        n = len(nums)
        left_products = [1] * n
        right_products = [1] * n
        answer = [1] * n

        left_product = 1
        for i in range(n):
            left_products[i] = left_product
            left_product *= nums[i]

        right_product = 1
        for i in range(n - 1, -1, -1):
            right_products[i] = right_product
            right_product *= nums[i]
        
        for i in range(n):
            answer[i] = left_products[i] * right_products[i]
        return answer
        
            
