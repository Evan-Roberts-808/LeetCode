/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var findMatrix = function(nums) {
    let result = [];

    for (let value of nums) {
        let valueFound = false;

        for (let row of result) {
            if (!row.includes(value)) {
                row.push(value);
                valueFound = true;
                break;
            }
        }

        if (!valueFound) {
            result.push([value]);
        }
    }

    return result;
};