public class Solution {

    public string Encode(IList<string> strs) {
        string c = "";
        foreach(string s in strs){
            int len = s.Length;
            c += len + "#" + s;
            
        }
        return c;
    }
    
    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
        int.TryParse(s[i..j].ToString(), out int idx);
        strs.Add(s.Substring(j+1, idx));
        i = j + 1 + idx;
        }
        return strs;
   }
}
