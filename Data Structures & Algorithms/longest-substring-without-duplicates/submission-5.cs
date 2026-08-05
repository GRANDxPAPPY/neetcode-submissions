public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int maxLength = 0;
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(set.Contains(s[i]))
            {
                while(set.Contains(s[i]))
                {
                    set.Remove(s[left]);
                    left++;
                }
            }
            if(!set.Contains(s[i]))
            {
                set.Add(s[i]);
            }
            maxLength = Math.Max(maxLength, i - left + 1);
        }
        return maxLength;
    }
}
