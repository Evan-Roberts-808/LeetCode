public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> result = new List<bool>();

        int maxCandies = candies[0];
        for (int i = 1; i < candies.Length; i++) {
            maxCandies = Math.Max(maxCandies, candies[i]);
        }

        foreach (int candyCount in candies) {
            result.Add(candyCount + extraCandies >= maxCandies);
        }

        return result;
    }
}
