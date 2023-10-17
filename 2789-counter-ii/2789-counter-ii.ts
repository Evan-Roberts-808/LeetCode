type ReturnObj = {
    increment: () => number,
    decrement: () => number,
    reset: () => number,
}

function createCounter(init: number): ReturnObj {
    let currentVal : number = init;
	return {
        increment: () => {
            return currentVal += 1;
        },
        decrement: () => {
            return currentVal -= 1;
        },
        reset: () => {
            return currentVal = init;
        }
    }
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */

//  let currentValue = init

//     return {
//         increment:function(){
//             return currentValue += 1
//         },

//         decrement:function(){
//             return currentValue -= 1
//         },

//         reset:function(){
//             return currentValue = init
//         }
//     }