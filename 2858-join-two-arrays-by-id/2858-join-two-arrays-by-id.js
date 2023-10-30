/**
 * @param {Array} arr1
 * @param {Array} arr2
 * @return {Array}
 */
var join = function(arr1, arr2) {
    const idMap = {};

    for (const obj of arr1) {
        idMap[obj.id] = obj;
    }

    for (const obj of arr2) {
        if (idMap[obj.id]) {
            idMap[obj.id] = { ...idMap[obj.id], ...obj };
        } else {
            idMap[obj.id] = obj;
        }
    }

    const result = Object.values(idMap).sort((a, b) => a.id - b.id);
    return result;
};
