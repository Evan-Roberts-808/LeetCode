class EventEmitter {
    constructor() {
        this.events = new Map();
    }

    subscribe(eventName, callback) {
        if (!this.events.has(eventName)) {
            this.events.set(eventName, []);
        }
        const eventCallbacks = this.events.get(eventName);
        eventCallbacks.push(callback);
        const unsubscribe = () => {
            const index = eventCallbacks.indexOf(callback);
            if (index > -1) {
                eventCallbacks.splice(index, 1);
            }
        };
        return { unsubscribe };
    }

    emit(eventName, args = []) {
        if (!this.events.has(eventName)) {
            return [];
        }
        const eventCallbacks = this.events.get(eventName);
        const results = [];
        for (const callback of eventCallbacks) {
            results.push(callback(...args));
        }
        return results;
    }
}


/**
 * const emitter = new EventEmitter();
 *
 * // Subscribe to the onClick event with onClickCallback
 * function onClickCallback() { return 99 }
 * const sub = emitter.subscribe('onClick', onClickCallback);
 *
 * emitter.emit('onClick'); // [99]
 * sub.unsubscribe(); // undefined
 * emitter.emit('onClick'); // []
 */