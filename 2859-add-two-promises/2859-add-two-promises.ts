type P = Promise<number>

async function addTwoPromises(promise1: P, promise2: P): P {
	return new Promise(async (resolve, reject) => {
        try {
            const result1 : number = await promise1;
            const result2 : number = await promise2;
            resolve(result1 + result2);
        } catch (error) {
            reject(error);
        }
    });
};

/**
 * addTwoPromises(Promise.resolve(2), Promise.resolve(2))
 *   .then(console.log); // 4
 */