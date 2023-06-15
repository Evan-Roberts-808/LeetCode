class Solution(object):
    def runningSum(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        running_sum = []
        sum = 0

        for i in range(len(nums)):
            sum += nums[i]
            running_sum.append(sum)
        return running_sum