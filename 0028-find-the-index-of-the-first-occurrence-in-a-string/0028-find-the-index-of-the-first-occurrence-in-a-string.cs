public class Solution {
    public int StrStr(string haystack, string needle) {
        int m = haystack.Length;
        int n = needle.Length;
        
        for (int i = 0; i < m - n + 1; i++)
        {
            if (haystack.Substring(i, n) == needle)
            {
                return i;
            }
        }
        
        return -1;
    }
}