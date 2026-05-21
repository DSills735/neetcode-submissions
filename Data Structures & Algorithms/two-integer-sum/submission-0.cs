public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] solution = [];
        for(int i = 0; i < nums.Length; ++i){
            if(dict.ContainsKey(target - nums[i])){
                int temp = target - nums[i];
                solution = [dict[temp], i];
                return solution;
            }
            else{
                dict[nums[i]] = i;
            }
            
        }
        return solution;
    }
}
