public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> numList = new List<int>(nums);
        numList.RemoveAll(item => item == val);
        numList.CopyTo(nums);
        return numList.Count;
    }
}
