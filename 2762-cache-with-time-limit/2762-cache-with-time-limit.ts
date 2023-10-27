class TimeLimitedCache {
    cache: Map<number, [number, number]>
    
    constructor() {
        this.cache = new Map();
    }
    
    set(key: number, value: number, duration: number): boolean {
        const now = Date.now();
        if (this.cache.has(key)) {
            this.cache.set(key, [value, now + duration])
            return true;
        }
        this.cache.set(key, [value, now + duration])
        return false;
    }

    get(key: number): number {
        const now = Date.now();
        if (this.cache.has(key)) {
            const [value, expiry] = this.cache.get(key)!;
            if (now < expiry) {
                return value;
            } else {
                this.cache.delete(key);
            }
        }
        return -1;
    }

    count(): number {
        const now = Date.now();
        let count = 0;
        for (const [key, [_, expiry]] of this.cache) {
            if (now < expiry) {
                count++;
            } else {
                this.cache.delete(key);
            }
        }
        return count;
    }
}

/**
 * const timeLimitedCache = new TimeLimitedCache()
 * timeLimitedCache.set(1, 42, 1000); // false
 * timeLimitedCache.get(1) // 42
 * timeLimitedCache.count() // 1
 */