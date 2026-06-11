public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] result = new int[nums.Length * 2];
        for(int i = 0; i < result.Length; i++)
        {
            if (i < nums.Length)
            {
                result[i] = nums[i];
            }
            else
            {
                result[i] = nums[i - (result.Length / 2)];
            }
        }

        return result;
    }
}