public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach(var word in strs)
        {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if(!map.ContainsKey(key))
            {
                // if the sorted looped word doesn't match, it is a subarray
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }
        return map.Values.ToList<List<string>>();
    }
}
