public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        var limit = nums.Length - 1;

        for (var i = 0; i <= limit; i++)
        {
           if(i == limit)
                return false;

            var currentValue = nums[i];
            var nextValue = nums[i + 1];

            if (currentValue == nextValue)
                return true;
        }

        return false;
    }
}