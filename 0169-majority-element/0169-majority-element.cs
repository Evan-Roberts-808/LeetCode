public class Solution {
    public int MajorityElement(int[] nums)
{
    int candidate = nums[0];
    int count = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (count == 0)
        {
            candidate = nums[i];
            count = 1;
        }
        else if (nums[i] == candidate)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    if (count > 0 && nums.Count(x => x == candidate) > nums.Length / 2)
    {
        return candidate;
    }
    else
    {
        return -1;
    }
}
}