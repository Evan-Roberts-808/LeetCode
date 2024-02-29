public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        if (strs.Any(str => str.Length == 0))
        {
            return "";
        }

        string reference = strs[0];

        if (!strs.All(str => str[0] == reference[0]))
        {
            return "";
        }

        int shortest = strs.Min(s => s.Length);
        int i = 1;

        while (i < shortest && i < reference.Length)
        {
            foreach (string str in strs)
            {
                if (i >= str.Length || str[i] != reference[i])
                {
                    return reference.Substring(0, i);
                }
            }
            i++;
        }

        return reference.Substring(0, shortest);
    }
}
