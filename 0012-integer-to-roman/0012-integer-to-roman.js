/**
 * @param {number} num
 * @return {string}
 */
var intToRoman = function(num) {
    const romanNumerals = {
    1000: 'M',
    900: 'CM',
    500: 'D',
    400: 'CD',
    100: 'C',
    90: 'XC',
    50: 'L',
    40: 'XL',
    10: 'X',
    9: 'IX',
    5: 'V',
    4: 'IV',
    1: 'I',
  };

  let result = '';
  const sortedNumerals = Object.entries(romanNumerals).sort((a, b) => b[0] - a[0]);
  for (const [value, symbol] of sortedNumerals) {
    while (num >= value) {
      result += symbol;
      num -= value;
    }
  }
  return result;
};