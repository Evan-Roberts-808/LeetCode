import java.util.HashMap;
import java.util.Map;

class Solution {
    public char findTheDifference(String s, String t) {
        Map<Character, Integer> counter = new HashMap<>();

        for (int i = 0; i < s.length(); i++) {
            char ch = s.charAt(i);
            counter.put(ch, counter.getOrDefault(ch, 0) + 1);
        }

        for (int i = 0; i < t.length(); i++) {
            char ch = t.charAt(i);
            if (!counter.containsKey(ch) || counter.get(ch) == 0) {
                return ch;
            }
            counter.put(ch, counter.get(ch) - 1);
        }
        return ' ';
    }
}
