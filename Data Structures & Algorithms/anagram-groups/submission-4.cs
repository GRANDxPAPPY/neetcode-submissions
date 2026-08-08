public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();
        List<List<string>> returnList = new List<List<string>>();
        foreach(string s in strs)
        {
            string str1 = HelperMethod(s);
            if(dict.ContainsKey(str1))
            {
                dict[str1].Add(s);
            }
            else
            {
                dict.Add(str1, new List<string>(){s});
            }
            
            
        }
        foreach(var v in dict.Values)
            {
                returnList.Add(v);
            }
        return returnList;
        

    }
    public string HelperMethod(string s)
    {
        char[] str = s.ToCharArray();

        Array.Sort(str);
        return new StringBuilder().Append(str).ToString();
    }
}
