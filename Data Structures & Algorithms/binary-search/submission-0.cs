public class Solution {
    public int Search(int[] nums, int target) {

        var totalLength = nums.Length;
        int left = 0, right = totalLength - 1;

        while (left <= right){
            // var index = left + (right - left) / 2;
            var index = (left + right)/2;

            if(nums[index] == target){
                return index;
            }

            else if (nums[index] < target){
                left = index + 1;
            }

            else if (nums[index] > target){
                right = index - 1;
            }
        }

        return -1;        
    }
}