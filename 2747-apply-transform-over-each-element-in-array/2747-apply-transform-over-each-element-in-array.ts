function map(arr: number[], fn: (n: number, i: number) => number): number[] {
    let newArray : number[] = [];
    for (let i = 0; i < arr.length; i++) {
        newArray.push(fn(arr[i], i));
    }
    return newArray
};
