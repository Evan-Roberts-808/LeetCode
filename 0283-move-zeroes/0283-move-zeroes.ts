/**
 Do not return anything, modify nums in-place instead.
 */
function moveZeroes(nums: number[]): void {
    let j : number = 0;
    for(let i = 0; i < nums.length; i++){
        if (nums[i] !== 0) {
            let temp : number = nums[j]
            nums[j] = nums[i]
            nums[i] = temp
            j++
        }
    }  
    console.log(nums)
};
