class Solution(object):
    def majorityElement(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        count = 0
        candidate = None

        for num in nums:
            if count == 0:
                candidate = num
            if num == candidate:
                count += 1
            else:
                count -= 1

        # At this point, candidate contains a potential majority element
        # We need to check if it appears more than n/2 times in the list

        count = 0
        for num in nums:
            if num == candidate:
                count += 1

        if count > len(nums) / 2:
            return candidate
        else:
            return -1