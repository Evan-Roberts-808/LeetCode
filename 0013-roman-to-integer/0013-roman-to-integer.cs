public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<string, int> romanToInt = new Dictionary<string, int>()
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };

        int answer = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanToInt.ContainsKey(s.Substring(i, 2)))
            {
                answer += romanToInt[s.Substring(i, 2)];
                i++;
            }
            else if (romanToInt.ContainsKey(s.Substring(i, 1)))
            {
                answer += romanToInt[s.Substring(i, 1)];
            }
        }

        return answer;
    }
}
