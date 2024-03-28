public class Solution {
    public string Convert(string inputString, int numRows) {
        if (numRows == 1) return inputString;

        List<StringBuilder> rows = new List<StringBuilder>(Math.Min(numRows, inputString.Length));
        for (int i = 0; i < Math.Min(numRows, inputString.Length); i++) {
            rows.Add(new StringBuilder());
        }

        int direction = -1;
        int currentRow = 0;

        foreach (char c in inputString) {
            rows[currentRow].Append(c);
            currentRow += (direction == -1) ? 1 : -1;

            if (currentRow == 0 || currentRow == numRows - 1) {
                direction = -direction;
            }
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows) {
            result.Append(row);
        }

        return result.ToString();
    }
}
