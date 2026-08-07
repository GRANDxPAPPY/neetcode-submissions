public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] array = new int[nums.Length];
        Array.Fill(array,1);
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] < nums[j])
                {
                    array[i] = Math.Max(array[i], 1 + array[j]);
                }
            }
        }
        return array.Max();
    }
}
