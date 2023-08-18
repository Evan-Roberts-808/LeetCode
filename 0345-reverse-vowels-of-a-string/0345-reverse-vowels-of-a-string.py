class Solution(object):
    def reverseVowels(self, s):
        """
        :type s: str
        :rtype: str
        """
        s_list = list(s)

        vowels = set('aeiouAEIOU')

        l, r = 0, len(s) - 1

        while l < r:
            while l < r and s_list[l] not in vowels:
                l += 1
            while l < r and s_list[r] not in vowels:
                r -= 1
            s_list[l], s_list[r] = s_list[r], s_list[l]

            l, r = l + 1, r - 1
        return ''.join(s_list)