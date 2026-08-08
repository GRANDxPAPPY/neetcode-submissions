public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int start = 0;
        int count = 0;
        int rcount = 0;
        if(nums.Length == 0) return 0;
        if(set.Count == 1) return 1;
        rcount = 1;
        for (int i = 0; i < nums.Length; i++) {
            if (!set.Contains(nums[i] - 1)) {
                start = nums[i];
                count = 1;
                while (set.Contains(start + 1)) {
                    start ++;
                    count++;

                rcount = Math.Max(count, rcount);
                }
            }
        }

        return rcount;
    }
}
