public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            var complement = target - nums[i];
            if(!map.ContainsKey(complement)){
                map[nums[i]] = i;
            } else {
                return new int[] {map[complement], i};
            }
        }

        return new int[] {0, 0};
    }
}
