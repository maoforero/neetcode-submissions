public class Solution {
    public bool IsAnagram(string s, string t) {
            
            var sLower = s.ToLower();
            var tLower = t.ToLower();

            if(sLower.Length != tLower.Length)
                return false;

            var sSort = sLower.OrderBy(a => a).ToArray();
            var tSort = tLower.OrderBy(b => b).ToArray();

            return sSort.SequenceEqual(tSort);
        }
    }
