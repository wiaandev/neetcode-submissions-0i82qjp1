public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var key = nums[i];
            if(map.ContainsKey(key))
            {
                map[key]++;
            } else {
                map[key] = 1;
            }
        }

        // we create buckets for the amount of elements in the array
        var buckets = new List<int>[nums.Length + 1];
        for(int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach(var kvp in map)
        {
            var key = kvp.Key;
            var freq = kvp.Value;
            buckets[freq].Add(key);
        }

        var results = new List<int>();

        // start counting from the back
        for(int i = buckets.Length - 1; i>=0 && results.Count < k; i--)
        {
            foreach(var num in buckets[i])
            {
                results.Add(num);
                if(results.Count == k)
                {
                    break;
                }
            };
        }
        return results.ToArray();

    }
}
