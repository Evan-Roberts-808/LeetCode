public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {

        int totalGas = gas.Sum() - cost.Sum();
        
        if (totalGas < 0)
        {
            return -1;
        }
        
        int start = 0;
        int currentTank = 0;
        
        for (int i = 0; i < gas.Length; i++)
        {
            currentTank += gas[i] - cost[i];
            if(currentTank < 0)
            {
                start = i + 1;
                currentTank = 0;
            }
        }
        currentTank += gas[start];
        
        return start;
    }
}