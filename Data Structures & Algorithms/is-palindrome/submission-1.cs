public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        string trimmed = s.Trim().ToLower();
        int end = trimmed.Length - 1;

        while(start < trimmed.Length - 1 && end >= 0){
            if(!char.IsLetterOrDigit(trimmed[end])){
                end -= 1;
            }
            else if(!char.IsLetterOrDigit(trimmed[start])){
                start += 1;
            }
            else if(trimmed[start] != trimmed[end]){
                return false;
            }
            else{
                start += 1;
                end -= 1;
            }
            if(start == end || start > end){
                return true;
            }
        }
        return true;
    }
}
