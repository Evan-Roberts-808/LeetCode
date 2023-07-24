class Solution(object):
    def canConstruct(self, ransomNote, magazine):
        """
        :type ransomNote: str
        :type magazine: str
        :rtype: bool
        """
        #initialize the hash table
        char_counts = {}
        
        #count charactesr in the magazine
        for char in magazine:
            char_counts[char] = char_counts.get(char, 0) + 1
            
        #check ransom note characters against the hash table
        for char in ransomNote:
            if char_counts.get(char, 0) > 0:
                char_counts[char] -= 1
            else:
                return False
        return True