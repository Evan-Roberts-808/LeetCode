using System.Text.RegularExpressions;

public class Solution {
  public string ReverseWords(string s) {
    s = Regex.Replace(s.Trim(), @"\s+", " ");

    if (s.Length == 0) {
      return "";
    }

    StringBuilder reversedString = new StringBuilder();
    int start = s.Length - 1, end = s.Length;

    while (start >= 0) {
      if (s[start] == ' ') {
        reversedString.Append(' ');
        reversedString.Append(s.Substring(start + 1, end - start - 1));
        end = start;
      } else if (start == 0) {
        reversedString.Append(' ');
        reversedString.Append(s.Substring(start, end - start));
      }
      start--;
    }

    return reversedString.ToString().Trim();
  }
}
