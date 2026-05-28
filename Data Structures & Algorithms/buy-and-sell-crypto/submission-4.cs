public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 101;
        int profit = 0;
        for(int i = 0; i < prices.Length; ++i){
            if(prices[i] < buy){
                buy = prices[i];
            }
            profit = Math.Max(profit, prices[i] - buy);
            
        }
        return profit;
    }
}
