public class Solution {

        public string Encode(IList<string> strs) {
        if (strs.Count == 0) return "dont";
        string x = string.Join("QWE",strs);
       return x;
    }

    public List<string> Decode(string s) {
        if(s =="dont") return new List<string>();
        List<string> x = s.Split("QWE").ToList();
        return x;
   }
}