public class Solution {
    public bool IsPalindrome(string s) {
        if (s == null) return false;    


        var sLower = s.ToLower();
        var sClean = Regex.Replace(sLower, "[^a-z0-9]", "");

        var original = sClean.ToArray();
        var reversed = sClean.Reverse().ToArray();

        return original.SequenceEqual(reversed);
    }
}