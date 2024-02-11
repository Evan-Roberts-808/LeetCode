public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
      int[] originalIndices = Enumerable.Range(0, nums.Length).ToArray();

      Array.Sort(nums, originalIndices);

      int left = 0;
      int right = nums.Length - 1;

      while (left < right)
      {
        int currentSum = nums[left] + nums[right];

        if (currentSum == target)
        {
          return new int[] { originalIndices[left], originalIndices[right] };
        }
        else if (currentSum < target)
        {
          left++;
        }
        else
        {
          right--;
        }
      }

      return new int[0];
    }
}