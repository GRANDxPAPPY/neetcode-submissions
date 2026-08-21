public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> subset = new List<List<int>>();
        List<int> currset = new List<int>();

        dfs(0, nums, subset, currset);
        return subset;

    }

    public void dfs(int i, int[] nums, List<List<int>> subset, List<int> currset)
    {
        if(i >= nums.Length)
        {

            
            subset.Add(new List<int>(currset));
            return;
        
        }
        currset.Add(nums[i]);
        dfs(i + 1, nums, subset, currset);
        currset.RemoveAt(currset.Count - 1);
        dfs(i + 1, nums, subset, currset);

    }

}