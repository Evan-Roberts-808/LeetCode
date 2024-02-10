public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder();

        while (columnNumber > 0) {
            columnNumber--;
            int remainder = columnNumber % 26;
            sb.Insert(0, (char)(remainder + 'A'));
            columnNumber /= 26;
        }

        return sb.ToString();
    }
}
