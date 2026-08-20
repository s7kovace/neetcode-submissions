public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>(); //key -> value

        for (int i = 0; i < nums.Length; i++){
            var compliment = target - nums[i];

            if(dict.ContainsKey(compliment)){
                return [dict[compliment], i];
            }

            dict.Add(nums[i], i);

        }

        return[0];
    }
}
