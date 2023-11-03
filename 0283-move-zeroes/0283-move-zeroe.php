class Solution {
    /**
     * @param Integer[] $nums
     * @return NULL
     */
    function moveZeroes(&$nums) {
        $n = count($nums);
        $j = 0;
        
        for ($i = 0; $i < $n; $i++) {
            if ($nums[$i] != 0) {
                $temp = $nums[$i];
                $nums[$i] = $nums[$j];
                $nums[$j] = $temp;
                $j++;
            }
        }
    }
}
