import numpy as np

class Solution(object):
    def checkStraightLine(self, coordinates):
        """
        :type coordinates: List[List[int]]
        :rtype: bool
        """
        if len(coordinates) == 2:
            return True
        
        p1, p2, p3 = coordinates[:3]
        v1 = np.array(p2) - np.array(p1)
        
        for point in coordinates[2:]:
            v2 = np.array(point) - np.array(p1)
            cross_product = np.cross(v1, v2)
            if not np.all(cross_product == 0):
                return False
        
        return True