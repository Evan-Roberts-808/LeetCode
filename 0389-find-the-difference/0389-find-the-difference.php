class Solution {

    /**
     * @param String $s
     * @param String $t
     * @return String
     */
    function findTheDifference($s, $t) {
        $counter = [];
        
        for ($i = 0; $i < strlen($s); $i++) {
            $ch = $s[$i];
            if (array_key_exists($ch, $counter)) {
                $counter[$ch]++;
            } else {
                $counter[$ch] = 1;
            }
        }

        for ($i = 0; $i < strlen($t); $i++) {
            $ch = $t[$i];
            if (!array_key_exists($ch, $counter) || $counter[$ch] == 0) {
                return $ch;
            }
            $counter[$ch]--;
        }
        return '';
    }
}
