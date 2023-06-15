/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function(nums) {
    let runningSum = [] // creates enpty array to store running sum
    let sum = 0 // initializes sum at 0

    for (let i = 0; i < nums.length; i++) { //iterates over length of nums and increments by 1
        sum += nums[i] // adds the current indexed number from num to sum and sets the value of sum 
        runningSum.push(sum) // pushes that value to array
    } // loops to next number adding that to the now updated sum value and pushes it

    return runningSum // returns runningSum array that now holds values
};