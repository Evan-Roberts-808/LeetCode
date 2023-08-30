class Solution(object):
    def longestCommonPrefix(self, strs):
        """
        :type strs: List[str]
        :rtype: str
        """
        if len(strs) == 0:
            return ""

        shortest = len(min(strs, key=len))
        i = 0

        reference = strs[0]

        while i < shortest:
            for string in strs:
                if string[i] != reference[i]:
                    return reference[:i]
            i += 1

        return reference[:shortest]