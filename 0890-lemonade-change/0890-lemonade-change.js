/**
 * @param {number[]} bills
 * @return {boolean}
 */
var lemonadeChange = function(bills) {
    let fives = tens = 0

    for(let i = 0; i < bills.length; i++){
        if (bills[i] === 5) {
            fives += 1
        } else if (bills[i] === 10) {
            if (!fives) {
                return false
            }
            fives -= 1
            tens += 1
        } else {
            if (tens && fives) {
                tens -= 1
                fives -= 1
            } else if (fives >= 3) {
                fives -= 3
            } else {
                return false
            }
        }
    }
    return true
};
