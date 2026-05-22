public class Solution {
    public bool IsValidSudoku(char[][] board) {
        foreach(char[] num in board){
            HashSet<int> rows = new HashSet<int>();
            foreach (char c in num){
                if(c == '.'){
                    continue;
                }
                else if(rows.Contains(c)){
                    return false;
                }
                else{
                    rows.Add(c);
                }
            }
        }

        for(int i = 0; i < board.Length; ++i){
        HashSet<int> cols = new HashSet<int>();
        foreach(char[] nums in board){
            if(nums[i] == '.'){
                continue;
            }
            else if(cols.Contains(nums[i])){
                return false;
            }
            else{
                cols.Add(nums[i]);
            }
        }
        }
        Dictionary<(int, int), HashSet<char>> box = new Dictionary<(int, int), HashSet<char>>();
        for(int i = 0; i < board.Length; ++i){
            for(int j = 0; j < board.Length; ++j){
                if(board[i][j] == '.'){
                continue;
            }
            var idx = (i / 3, j / 3);
            if(!box.ContainsKey(idx)){
                box[idx] = new HashSet<char>();
            }
            if(box[idx].Contains(board[i][j])){
                return false;
            }
            box[idx].Add(board[i][j]);
            }
        }
        return true;
    }
}
