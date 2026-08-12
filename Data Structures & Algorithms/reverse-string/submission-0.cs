public class Solution {
    public void ReverseString(char[] s) {
        char[] arr = new char[s.Length];
        Array.Copy(s,arr,s.Length);
        int j =0;
        for(int i = s.Length -1; i>=0; i--)
        {
            s[j] = arr[i];
            j++;
        }
        
    }
}