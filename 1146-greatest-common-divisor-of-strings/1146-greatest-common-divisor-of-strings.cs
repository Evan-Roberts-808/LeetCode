public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (!string.Equals(str1 + str2, str2 + str1)){
            return "";
        }

        int len1 = str1.Length;
        int len2 = str2.Length;

        while (len2 != 0) {
            int temp = len2;
            len2 = len1 % len2;
            len1 = temp;
        }

        return str1.Substring(0, len1);
    }
}