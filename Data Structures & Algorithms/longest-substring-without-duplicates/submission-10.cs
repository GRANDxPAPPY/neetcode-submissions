public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int maxLength= 0;
        if(s.Length == 1) return 1;
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < s.Length; i++)
        {
            
            if(!set.Contains(s[i]))
            {
                set.Add(s[i]);
            }
            
            else
            {
                maxLength = Math.Max(i - left, maxLength);
                while(set.Contains(s[i]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[i]);
            }
            maxLength = Math.Max(i - left + 1, maxLength);
            
        }
        return maxLength;
    }
}
