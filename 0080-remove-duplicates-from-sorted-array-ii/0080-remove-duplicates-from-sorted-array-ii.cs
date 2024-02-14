public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1])
            {
                count += 1;
            } else
            {
              count = 1;  
            }
            if (count <= 2)
            {
                k+=1;
                if (i != k)
                {
                    nums[k]=nums[i];
                }
            }
        }
        return k + 1;
    }
}