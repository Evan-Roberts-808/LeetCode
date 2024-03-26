public class Solution {
    public int ClimbStairs(int n) {
        int pre = 1;
        int curr = 1;
        int temp = 0;
        
        for (int i = 1; i < n; i++)
        {
            temp = curr;
            curr += pre;
            pre = temp;
        }
        return curr;
    }
}