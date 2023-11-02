using System.Collections.Generic;

public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char, int> counter = new Dictionary<char, int>();

        foreach (char ch in s) {
            if (counter.ContainsKey(ch)) {
                counter[ch]++;
            } else {
                counter[ch] = 1;
            }
        }

        foreach (char ch in t) {
            if (!counter.ContainsKey(ch) || counter[ch] == 0) {
                return ch;
            }
            counter[ch]--;
        }
        return ' ';
    }
}
