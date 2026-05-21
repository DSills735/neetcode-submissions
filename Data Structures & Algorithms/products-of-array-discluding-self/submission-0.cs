public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int [] outp = new int [n];

        int left = 1;
        for(int i = 0; i < nums.Length; ++i){
            outp[i] = left;
            left *= nums[i];
        }

        int right = 1;
        for(int i = n - 1; i >= 0; --i){
            outp[i] *= right;
            right *= nums[i];
        }
        return outp;
    }
}
