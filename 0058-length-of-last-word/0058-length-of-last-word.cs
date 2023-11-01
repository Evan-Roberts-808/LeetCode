public class Solution {
    public int LengthOfLastWord(string s) {
        string[] split = s.Trim().Split(" ");
        if (split.Length > 0) {
            return split[split.Length - 1].Length;
        }
        return 0;
    }
}
