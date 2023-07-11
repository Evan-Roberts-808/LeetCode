class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        if not s:
            return 0
        
        unique = []
        max_length = 0
        
        for i in s:
            if i not in unique:
                unique.append(i)
                max_length = max(max_length, len(unique))
            else:
                unique = unique[unique.index(i) + 1:]
                unique.append(i)
        
        return max_length