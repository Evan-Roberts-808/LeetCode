class Solution(object):
    def merge(self, intervals):
        """
        :type intervals: List[List[int]]
        :rtype: List[List[int]]
        """
        intervals.sort()
        merged = []
        
        merged.append(intervals[0])
        for i in intervals[1:]:
            if merged[-1][0] <= i[0] <= merged[-1][-1]:
                merged[-1][-1] = max(merged[-1][-1], i[-1])
            else:
                merged.append(i)
        return merged