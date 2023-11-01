function lengthOfLastWord(s: string): number {
    let split : string[] = s.trim().split(" ");
    if (split.length > 0) {
        return split[split.length - 1].length;
    } else {
        return 0;
    }
};
