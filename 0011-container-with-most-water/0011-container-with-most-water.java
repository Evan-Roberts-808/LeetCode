class Solution {
    public int maxArea(int[] height) {
        int l = 0;
        int r = height.length - 1;
        int maxWater = 0;
        
        while (l < r) {
            int containerWidth = r - l;
            int min_height = Math.min(height[l], height[r]);
            int water = min_height * containerWidth;
            
            maxWater = Math.max(maxWater, water);
            
            if (height[l] < height[r]) {
                l += 1;
            } else {
                r -= 1;
            }
        }
        return maxWater;
    }
}
