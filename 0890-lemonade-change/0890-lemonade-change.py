class Solution(object):
    def lemonadeChange(self, bills):
        """
        :type bills: List[int]
        :rtype: bool
        """
        fives = tens = 0

        for customer in bills:
            if customer == 5:
                fives += 1
            elif customer == 10:
                if not fives:
                    return False
                fives -= 1
                tens += 1
            else:
                if tens and fives:
                    tens -= 1
                    fives -= 1
                elif fives >= 3:
                    fives -= 3
                else:
                    return False
        return True