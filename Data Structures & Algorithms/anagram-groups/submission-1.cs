public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<String>> dict = new Dictionary<String, List<String>>();
        List<List<string>> strings = new List<List<string>>();
        foreach(string s in strs){
            char[] sort = s.ToCharArray();
            Array.Sort(sort);
            string sorted = new string(sort);
            if(dict.ContainsKey(sorted)){
                dict[sorted].Add(s); 
            }
            else{
                dict[sorted] = new List<string> {s};
            }
        }
        foreach(var value in dict.Values){
            strings.Add(value);
        }
        
        return strings;
    }
}

