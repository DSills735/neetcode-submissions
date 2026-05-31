public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> num = new HashSet<int>();
        int count = 0;
        int max = 0;
        foreach(int n in nums){
            if(!num.Contains(n)){
                num.Add(n);
            }
        }
        foreach(int n in num){
            if(!num.Contains(n - 1)){
                count = 1;
            while(num.Contains(n + count)){
                count += 1; 
            } 
            if(count > max){
                max = count;
            }
        }
    }
    return max;
    }
}
