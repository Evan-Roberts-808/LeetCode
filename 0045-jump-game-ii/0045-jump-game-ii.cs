public class Solution {
    public int Jump(int[] nums) {
        int jumps = 0;
        int currentMaxReach = 0;
        int nextMaxReach = 0;
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            nextMaxReach = Math.Max(nextMaxReach, i + nums[i]);
            if(i == currentMaxReach)
            {
                jumps++;
                currentMaxReach = nextMaxReach;
            }
        }
        return jumps;
    }
}