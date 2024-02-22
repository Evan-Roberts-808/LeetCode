public class RandomizedSet {
    private List<int> nums;
    private Dictionary<int, int> indexMap;
    private Random rand;
    public RandomizedSet() {
        nums = new List<int>();
        indexMap = new Dictionary<int, int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {
        if (indexMap.ContainsKey(val)) {
            return false;
        }

        nums.Add(val);
        indexMap[val] = nums.Count - 1;
        return true;
    }
    
    public bool Remove(int val) {
        if (!indexMap.ContainsKey(val)) {
            return false;
        }

        int lastElement = nums[nums.Count - 1];
        int valIndex = indexMap[val];

        nums[valIndex] = lastElement;
        indexMap[lastElement] = valIndex;

        nums.RemoveAt(nums.Count - 1);
        indexMap.Remove(val);

        return true;
    }
    
    public int GetRandom() {
        int randomIndex = rand.Next(nums.Count);
        return nums[randomIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */