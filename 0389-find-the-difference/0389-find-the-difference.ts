function findTheDifference(s: string, t: string): string {
    const counter : Record<string, number> = {}

    for (let i = 0; i < s.length; i++) {
        counter[s[i]] = (counter[s[i]] || 0) + 1
    }

    for (let i = 0; i < t.length; i++) {
        if (!counter[t[i]]) {
            return t[i]
        }
        counter[t[i]] -= 1
    }
};
