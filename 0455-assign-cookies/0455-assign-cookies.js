/**
 * @param {number[]} g
 * @param {number[]} s
 * @return {number}
 */
var findContentChildren = function(g, s) {
    g.sort((a, b) => a - b)
    s.sort((a, b) => a - b)
    let count = 0;
    let j = 0;
    
    for (let i = 0; i < g.length; i++) {
        while (j < s.length && s[j] < g[i]) {
            j++
        }
        
        if (j < s.length) {
            count++
            j++
        } else {
            break
        }
    }
    return count
};