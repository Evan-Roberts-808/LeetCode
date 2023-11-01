/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    let split = s.trim().split(" ");
    if (split.length > 0) {
        return split[split.length - 1].length;
    } else {
        return 0;
    }
};
