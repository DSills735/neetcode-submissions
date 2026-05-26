public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int left = 1; 
        int right = nums.Length - 1;
        List<List<int>> trips = new List<List<int>>();
        Array.Sort(nums);

        for(int fix = 0; fix < nums.Length - 2; ++fix){
            if(fix > 0 && nums[fix] == nums[fix - 1]){
                continue;
            }
            left = fix + 1;
            right = nums.Length - 1;
            while(left < right)
            {
                if(nums[fix] + nums[left] + nums[right] == 0){
                    trips.Add(new List<int> { nums[fix], nums[left], nums[right] });
                    left += 1;
                    while(left < right && nums[left] == nums[left - 1]){
                        left += 1;
                    }
                }
                else if(nums[fix] + nums[left] + nums[right] > 0){
                    right -= 1;
                }
                else{
                    left += 1;
                }
            }
            
        }
        return trips;
    
        
    }
}
