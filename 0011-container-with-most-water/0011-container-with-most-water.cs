public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int maxWater = 0;
        
        while (l < r) {
            int containerWidth = r - l;
            int min_height = Math.Min(height[l], height[r]);
            int water = min_height * containerWidth;
            
            maxWater = Math.Max(maxWater, water);
            
            if (height[l] < height[r]) {
                l += 1;
            } else {
                r -= 1;
            }
        }
        return maxWater;
    }
}