public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> visited = new HashSet<int>();
        
        while (n != 1)
        {
            int sumOfSquares = 0;
            
            while (n > 0)
            {
                int digit = n % 10;
                sumOfSquares += (int)Math.Pow(digit, 2);
                n /= 10;
            }
            
            if (visited.Contains(sumOfSquares))
            {
                return false;
            }
            visited.Add(sumOfSquares);
            n = sumOfSquares;
        }
        return true;
    }
}
