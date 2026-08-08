public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i = 0;  i < nums.Length; i++)
        {
            int answer = target - nums[i];
            if(dict.ContainsKey(answer))
            {
                return new int[] {dict[answer],i};
             }
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],i);
            }
            
        }
        return new int[0];
        //answer = target - nums;
        

    }
}
