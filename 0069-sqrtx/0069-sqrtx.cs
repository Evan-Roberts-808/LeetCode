public class Solution {
    public int MySqrt(int x) {
        double Prev = 0;
        double Cur = x;
        while ((int)Prev != (int)Cur){
            Prev = Cur;
            Cur = Cur - ((Cur * Cur) - x) / (2 * Cur);
        }
        return (int)(Cur - (Cur % 1));
    }
}