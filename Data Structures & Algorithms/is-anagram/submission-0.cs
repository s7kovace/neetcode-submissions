public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        var dict = new Dictionary<char,int>();

        foreach (char c in s){
            dict[c] = dict.GetValueOrDefault(c) + 1;
        }

        foreach (char c in t){
            if(!dict.TryGetValue(c, out var n) || n == 0) return false;
            
            dict[c] = n - 1;
        }

        return true;
    }
}
