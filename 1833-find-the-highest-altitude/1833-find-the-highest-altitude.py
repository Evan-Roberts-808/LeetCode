class Solution(object):
    def largestAltitude(self, gain):
        """
        :type gain: List[int]
        :rtype: int
        """
        altitude = 0
        highest = 0
        for i in range(len(gain)):
            altitude = altitude + gain[i]
            highest = max(highest, altitude)
        return highest