public class Solution {
    public bool IsAnagram(string s, string t) {
            // loop over both strings and make sure
            // both chars appear in each word.
            // make sure the strings are of equal length 
            if(s.Length != t.Length)
            {
                return false;
            }
            var map = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(!map.ContainsKey(s[i]))
                {
                    map[s[i]] = 1;
                } else {
                    map[s[i]]++;
                }
                
            }
            for(int j = 0; j < t.Length; j++)
            {
                if(!map.ContainsKey(t[j]) || map[t[j]] == 0)
                {
                    // may be that it may not found the char yet
                    return false;
                }
                map[t[j]]--;
            }
            return true;

    }
}
