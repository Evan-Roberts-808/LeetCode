var majorityElement = function(nums) {
    let maxCount = 0;
    let index = -1;

    for (let i = 0; i < nums.length; i++) {
        let count = 0;
        for (let j = 0; j < nums.length; j++) {
            if (nums[i] == nums[j]) {
                count++;
            }
        }
        if (count > maxCount) {
            maxCount = count;
            index = i;
        }
    }

    if (maxCount > nums.length / 2) {
        return nums[index];
    } else {
        return -1; // No majority element found
    }
};
