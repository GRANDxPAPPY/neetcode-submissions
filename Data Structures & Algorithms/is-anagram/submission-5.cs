public class Solution {
    public bool IsAnagram(string s, string t) {
        string str1 = helper(s);
        string str2 = helper(t);
        if(str1 == str2)
        {
            return true;
        }
        return false;
    }

    public string helper(string s)
    {
        char[] str = s.ToCharArray();
        Array.Sort(str);
        StringBuilder stt = new StringBuilder().Append(str);
        return stt.ToString();
    }
}
