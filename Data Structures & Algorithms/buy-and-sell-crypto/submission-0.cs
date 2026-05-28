public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 101;
        int sell = 0;
        int profit = 0;
        for(int i = 0; i < prices.Length; ++i){
            if(prices[i] < buy){
                buy = prices[i];
            }
            if(prices[i] - buy > 0 && prices[i] - buy > profit){
                sell = prices[i];
                profit = Math.Max(profit, prices[i] - buy);
            }
         
        }
        return profit;
    }
}
