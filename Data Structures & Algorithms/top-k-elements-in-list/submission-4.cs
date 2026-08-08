public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int[] arr = new int[k];
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] ++;
            }
            else
            {
                dict.Add(nums[i],1);
            }
        }
        List<KeyValuePair<int,int>> li = new List<KeyValuePair<int,int>>(dict);
        li.Sort((v1,v2) => v2.Value.CompareTo(v1.Value));
        int j = 0;
        while(k > 0)
        {
            arr[j] = li[j].Key;
            j++;
            k--;
        }
        return arr;
    }
}
