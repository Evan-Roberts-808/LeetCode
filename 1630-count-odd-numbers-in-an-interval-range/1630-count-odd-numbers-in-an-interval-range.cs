public class Solution {
    public int CountOdds(int low, int high) {
        return (int) (Math.Floor((high + 1) / 2.0) - Math.Floor(low / 2.0));
    }
}