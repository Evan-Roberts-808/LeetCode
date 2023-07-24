class Solution(object):
    def lengthOfLastWord(self, s):
        """
        :type s: str
        :rtype: int
        """
        s = s.strip()

        if not s:
            return 0

        lis = list(s.split(" "))

        return len(lis[-1])