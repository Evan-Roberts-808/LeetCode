class Solution(object):
    def wordPattern(self, pattern, s):
        """
        :type pattern: str
        :type s: str
        :rtype: bool
        """
        s = s.split()
        
        l_to_s = {}
        s_to_l = {}
        
        if len(pattern) != len(s):
            return False
        for index, letter in enumerate(pattern):
            if letter in l_to_s:
                if l_to_s[letter] != s[index]:
                    return False
            else:
                if s[index] in s_to_l:
                    return False
                else:
                    l_to_s[letter] = s[index]
                    s_to_l[s[index]] = letter
        return True