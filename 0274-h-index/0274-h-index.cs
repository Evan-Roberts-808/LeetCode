public class Solution
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);
        for (int i = 0; i < citations.Length; i++)
        {
            int potential = citations.Length - i;
            if(potential <= citations[i])
            {
                return potential;
            }
        }
        return 0;
    }
}
