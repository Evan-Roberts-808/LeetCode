class Solution(object):
    def mergeAlternately(self, word1, word2):
        """
        :type word1: str
        :type word2: str
        :rtype: str
        """
        merged = ""
        w1 = len(word1)
        w2 = len(word2)
        l = min(w1, w2)
        for i in range(l):
            merged += word1[i] + word2[i]
        if w1 == w2:
            return merged
        elif w1 > w2:
            return merged + word1[l:]
        elif w1 < w2:
            return merged + word2[l:]
