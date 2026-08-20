public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> subset = new List<List<int>>();
        List<int> curset = new List<int>();
        Array.Sort(nums);
        dfs(0,nums,curset, subset);
        return subset;

    }

    public void dfs(int i, int[] nums, List<int> curset, List<List<int>> subset)
    {
        if(i >= nums.Length)
        {
            subset.Add(new List<int>(curset));
            return;
        }
        curset.Add(nums[i]);
        dfs(i+1,nums,curset,subset);
        curset.RemoveAt(curset.Count -1);
        dfs(i + 1,nums,curset,subset);
    }
}
