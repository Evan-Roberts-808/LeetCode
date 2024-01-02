function findMatrix(nums: number[]): number[][] {
    let result : number[][] = [];

        for (let value of nums) {
            let valueFound : boolean = false;

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