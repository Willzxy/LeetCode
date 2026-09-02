public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int index = 0; index < nums.Length ; index++){
            int complement = target - nums[index];
            
            for(int compare = index + 1; compare < nums.Length; compare++){
                if(nums[compare] == complement){
                    return [index, compare];
                }
            }
        }

        return [0,0];
    }
}