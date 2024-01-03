class Solution(object):
    def numberOfBeams(self, bank):
        """
        :type bank: List[str]
        :rtype: int
        """
        prev_devices = 0
        beams = 0
        for row in bank:
            devices = sum(cell == '1' for cell in row)
            if devices > 0:
                beams += prev_devices * devices
                prev_devices = devices
        return beams