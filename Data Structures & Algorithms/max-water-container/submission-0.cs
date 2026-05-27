public class Solution {
    public int MaxArea(int[] heights) {
        int right = 0;
        int left = heights.Length - 1;
        int max = 0;
        while (right < left){
            
            if((left - right) * Math.Min(heights[left], heights[right]) > max){
                max = (left - right) * Math.Min(heights[left], heights[right]);
            }
            if(Math.Min(heights[left], heights[right]) == heights[left]){
                left -= 1;
            }
            else{
                right += 1;
            }
        }
        return max;
    }
}
