public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

     Dictionary<char, int> freq = new Dictionary<char, int>();

     foreach(char c in s){
        if(freq.ContainsKey(c)){
            freq[c]++;
        }
        else{
            freq[c] = 1;
        }
     }
    foreach(char c in t){
        if(freq.ContainsKey(c)){
            freq[c]--;
            if(freq[c] < 0){
                return false;
            }
        }
        else{
            return false;
        }
    }
    
    return true;
    
    }
}
