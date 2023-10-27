class Solution {
    public int countOdds(int low, int high) {
        return (int) ((long) Math.floor((high + 1) / 2) - (long) Math.floor(low / 2));
    }
}
