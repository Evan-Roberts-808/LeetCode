public class Solution {
    public int Candy(int[] ratings) {
        int[] candies = new int[ratings.Length];
        
        for (int i = 0; i < ratings.Length; i++) {
            if (i > 0 && ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            } else {
                candies[i] = 1;
            }
        }

        for (int i = ratings.Length - 1; i >= 0; i--) {
            if (i < ratings.Length - 1 && ratings[i] > ratings[i + 1]) {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }

        int totalCandies = 0;
        for (int i = 0; i < ratings.Length; i++) {
            totalCandies += candies[i];
        }

        return totalCandies;
    }
}