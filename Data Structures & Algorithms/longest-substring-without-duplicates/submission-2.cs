public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastInd = new Dictionary<char, int>();

        
        int left = 0;
        int count = 0;
        int max = 0;
        for(int right = 0; right < s.Length; right++){
            if(lastInd.ContainsKey(s[right]) && right >= left){
                left = Math.Max(left, lastInd[s[right]] + 1);
            }
            lastInd[s[right]] = right;
          max = Math.Max(right - left + 1, max);
        }
        return max;
    }
}
