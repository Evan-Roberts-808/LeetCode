public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> output = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            
            int l = i + 1;
            int r = nums.Length - 1;
            
            while (l < r)
            {
                int total = nums[i] + nums[l] + nums[r];
                
                if (total == 0)
                {
                    output.Add([nums[i], nums[l], nums[r]]);
                    
                    while (l < r && nums[l] == nums[l + 1])
                    {
                        l += 1;
                    }
                    while (l < r && nums[r] == nums[r - 1])
                    {
                        r -= 1;
                    }
                    
                    l += 1;
                    r -= 1;
                }
                else if (total < 0)
                {
                    l += 1;
                }
                else
                {
                    r -= 1;
                }
            }
        }
        return output;
    }
}
