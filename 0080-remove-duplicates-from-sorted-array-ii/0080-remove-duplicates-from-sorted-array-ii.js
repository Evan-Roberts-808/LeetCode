/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    let k = 0; // Initialize k to 0 to represent index of modified array
    let count = 1; // Initialize count to 1 for the first occurrence

    for (let i = 1; i < nums.length; i++) { // start for loop from index 1 to compare each element with the previous element
        if (nums[i] === nums[i - 1]) { // if the current element is a duplicate increment count by 1
            count++;
        } else {
            count = 1; // Reset count for a new unique element
        }

        if (count <= 2) { // checks if count is less than or equal to 2 to ensure that only the first two occurrences are retained
            k++; // increment k by 1 before assigning current element to nums[k] to ensure that the modified array is constructed correctly
            if (i !== k) { // if i is not equal to k the current element is being assigned to a new index
                nums[k] = nums[i];
            }
        }
    }

    return k + 1; // return k + 1 which signifies the length of the modified array
};