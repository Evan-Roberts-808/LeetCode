from collections import defaultdict

class Solution(object):
    def findTheDifference(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: str
        """
        char_count = defaultdict(int)

        for char in s:
            char_count[char] += 1

        for char in t:
            if char_count[char] == 0:
                return char
            char_count[char] -= 1