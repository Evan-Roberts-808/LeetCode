/**
 * @param {string} s
 * @param {string} t
 * @return {character}
 */
var findTheDifference = function(s, t) {
    const counter = {}

    for (let i = 0; i < s.length; i++) {
        counter[s[i]] = (counter[s[i]] || 0) + 1
    }

    for (let i = 0; i < t.length; i++) {
        if (!counter[t[i]]) {
            return t[i]
        }
        counter[t[i]] -= 1
    }
};
