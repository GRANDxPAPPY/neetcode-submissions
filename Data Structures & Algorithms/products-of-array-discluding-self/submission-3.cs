public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prev = 1;
        int sufix= 1;
        int[] output = new int[nums.Length];
        Array.Fill(output,1);

        for(int i = 0; i < nums.Length -1; i ++)
        {

            output[i + 1] = nums[i] * prev;
            prev = output[i + 1];
        }
        for(int j = nums.Length - 1; j >= 0; j--)
        {
            output[j] = output[j] * sufix;
            sufix = nums[j] * sufix;
        }
        return output;
    }
}
