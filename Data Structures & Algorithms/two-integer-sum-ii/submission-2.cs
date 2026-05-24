public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int index1 = 0;
        int index2 = numbers.Length - 1;

        int sol = -5000;

        while(sol != target && index1 < index2){
            sol = numbers[index1] + numbers[index2];

            if(sol == target){
                return [index1 + 1, index2 + 1];
            }
            else if(sol > target){
                index2 -= 1;
            }
            else{
                index1 += 1;
            }
        }
        return [-1, -1];
    }
}
