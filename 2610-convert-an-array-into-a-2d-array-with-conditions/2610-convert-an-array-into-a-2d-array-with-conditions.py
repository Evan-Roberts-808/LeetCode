class Solution(object):
    def findMatrix(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        result = []
        
        for value in nums:
            value_found = False
            for row in result:
                if (value not in row):
                    row.append(value)
                    value_found = True
                    break
            if not value_found:
                result.append([value])
                
        return result
        