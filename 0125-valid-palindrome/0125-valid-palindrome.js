/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    let polishedString = s.replace(/\W+|_/g, "").toLowerCase()
    let reversedString = polishedString.split("").reverse().join("")

    if (polishedString != reversedString) {
        return false
    }
    return true
};