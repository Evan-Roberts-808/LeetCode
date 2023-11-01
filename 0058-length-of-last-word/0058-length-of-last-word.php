class Solution {

    /**
     * @param String $s
     * @return Integer
     */
    function lengthOfLastWord($s) {
        $trimmedString = trim($s);
        $split = preg_split('/\s+/', $trimmedString);
        $lastWord = end($split);
        return strlen($lastWord);
    }
}
