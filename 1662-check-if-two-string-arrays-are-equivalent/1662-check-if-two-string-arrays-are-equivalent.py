class Solution(object):
    def arrayStringsAreEqual(self, word1, word2):
        """
        :type word1: List[str]
        :type word2: List[str]
        :rtype: bool
        """
        w1 = ''
        w2 = ''
        
        for i in range(len(word1)):
            w1 += word1[i]

        for j in range(len(word2)):
            w2 += word2[j]
            
        return w1 == w2