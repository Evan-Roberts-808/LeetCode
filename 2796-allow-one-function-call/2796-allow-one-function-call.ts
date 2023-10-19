type JSONValue = null | boolean | number | string | JSONValue[] | { [key: string]: JSONValue };
type OnceFn = (...args: JSONValue[]) => JSONValue | undefined

function once(fn: Function): OnceFn {
    let hasBeenCalled : boolean = false;
    let result : JSONValue;

	return function (...args) {
        if (!hasBeenCalled) {
        hasBeenCalled = true;
        result = fn.apply(this, args);
        return result;
        } else {
        return undefined;
        }
	};
}

/**
 * let fn = (a,b,c) => (a + b + c)
 * let onceFn = once(fn)
 *
 * onceFn(1,2,3); // 6
 * onceFn(2,3,6); // returns undefined without calling fn
 */