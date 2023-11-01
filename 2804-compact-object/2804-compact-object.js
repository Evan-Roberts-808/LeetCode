/**
 * @param {Object|Array} obj
 * @return {Object|Array}
 */
var compactObject = function (obj) {
  if (typeof obj === "object" && obj !== null) {
    if (Array.isArray(obj)) {
      return obj
        .map((item) => compactObject(item))
        .filter((item) => Boolean(item));
    } else {
      const result = {};
      for (const key in obj) {
        const value = compactObject(obj[key]);
        if (Boolean(value)) {
          result[key] = value;
        }
      }
      return result;
    }
  } else {
    return obj;
  }
};
