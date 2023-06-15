class Solution(object):
    roman_numerals = {
        'M': 1000,
        'CM': 900,
        'D': 500,
        'CD': 400,
        'C': 100,
        'XC': 90,
        'L': 50,
        'XL': 40,
        'X': 10,
        'IX': 9,
        'V': 5,
        'IV': 4,
        'I': 1,
    }

    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        answer = 0

        i = 0
        while i < len(s):

            if i == len(s) - 1:
                answer += self.roman_numerals[s[i]]
                i += 1
            else:

                if s[i:i+2] in self.roman_numerals:
                    answer += self.roman_numerals[s[i:i+2]]
                    i += 2
                else:
                    answer += self.roman_numerals[s[i]]
                    i += 1

        return answer
