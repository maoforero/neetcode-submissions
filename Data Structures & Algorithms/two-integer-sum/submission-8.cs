public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var result = new int[2];

        foreach(var item in nums){
            var diff  = target - item;
            var indexItem = Array.IndexOf(nums, item);
            var indexDiff = Array.LastIndexOf(nums, diff);

            if(nums.Contains(diff) && indexItem != indexDiff){
                result[0] = indexItem;
                result[1] = indexDiff;
            
                return result;
            } 
        }

        return result;
    }
}