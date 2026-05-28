public class Solution {
    public int Trap(int[] height) {
        int left = 0; 
        int right = height.Length - 1;
        int maxL = 0;
        int maxR = 0;
        int volume = 0;
        while(left < right){
            if(height[left] > maxL){
                maxL = height[left];
            }
            else{
                if(maxL > 0){
                    volume += maxL - height[left];
                }
            }
            if(height[right] > maxR){
                maxR = height[right];
            }
            else{
                if(maxR > 0){
                    volume += maxR - height[right];
                }
            }
            if(maxL > maxR){
                right -= 1;
            }
            else{
                left += 1;
            }
        }
        return volume;
    }
}
