type JSONValue = null | boolean | number | string | JSONValue[] | { [key: string]: JSONValue };

function join(arr1: JSONValue[], arr2: JSONValue[]): JSONValue[] {
    const idMap: { [id: number]: any } = {};

    for (const obj of arr1) {
        if (typeof obj === "object" && obj !== null) {
            const id = obj["id"];
            idMap[id] = obj;
        }
    }

    for (const obj of arr2) {
        if (typeof obj === "object" && obj !== null) {
            const id = obj["id"];
            if (idMap[id]) {
                idMap[id] = { ...idMap[id], ...obj };
            } else {
                idMap[id] = obj;
            }
        }
    }

    const result = Object.values(idMap).sort((a, b) => a.id - b.id);
    return result;
}
