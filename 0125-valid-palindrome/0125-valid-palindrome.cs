using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        string polishedString = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        
        if(polishedString == "")
        {
            return true;
        }
        
        char[] charArray = polishedString.ToCharArray();
        Array.Reverse(charArray);
        string reverseString = new string(charArray);
        
        return polishedString == reverseString ? true : false;
    }
}