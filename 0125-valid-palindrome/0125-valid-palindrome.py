class Solution(object):
    def isPalindrome(self, s):
        """
        :type s: str
        :rtype: bool
        """
        polished_string = re.sub(r'\W+|_', "", s.lower())
        reversed_string = polished_string[::-1]

        if (polished_string != reversed_string):
            return False
        return True