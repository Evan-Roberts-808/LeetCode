type MultiDimensionalArray = (number | MultiDimensionalArray)[];

const flat = (arr: MultiDimensionalArray, n: number): MultiDimensionalArray => {
  const res: MultiDimensionalArray = [];
  const stack: { item: MultiDimensionalArray; depth: number }[] = [];
  stack.push({ item: arr, depth: n });
  while (stack.length > 0) {
    let { item, depth } = stack.pop()!;
    if (!Array.isArray(item) || depth < 0) {
      res.push(item);
    } else {
      for (let i = item.length - 1; i >= 0; i--) {
        stack.push({ item: item[i] as MultiDimensionalArray, depth: depth - 1 });
      }
    }
  }
  return res;
};