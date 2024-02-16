public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    
    private static void Reverse(int[] nums, int start, int end)
    {
        while (start<end)
        {
            Swap(nums, start++, end--);
        }
    }
    
    private static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    
}