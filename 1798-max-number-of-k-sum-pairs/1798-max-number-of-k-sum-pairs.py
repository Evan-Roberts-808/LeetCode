class Solution(object):
    def maxOperations(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: int
        """
        if len(nums) < 2:
            return 0

        count = 0
        num_count = {}

        for num in nums:
            complement = k - num
            if complement in num_count and num_count[complement] > 0:
                count += 1
                num_count[complement] -= 1
            else:
                num_count[num] = num_count.get(num, 0) + 1

        return count