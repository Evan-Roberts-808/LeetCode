class Solution(object):
    def findDifference(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: List[List[int]]
        """
        unique1 = set()
        unique2 = set()
        answer = list()

        for i in range(len(nums1)):
            if nums1[i] not in nums2:
                unique1.add(nums1[i])
        for j in range(len(nums2)):
            if nums2[j] not in nums1:
                unique2.add(nums2[j])

        answer += list(unique1), list(unique2)
        return answer