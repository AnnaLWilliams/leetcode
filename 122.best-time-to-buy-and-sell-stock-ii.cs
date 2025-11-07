public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;

        if (prices.Length <= 1)
        {
            return 0;
        }

        for (var index = 1; index < prices.Length; index++)
        {
            if(prices[index] > prices[index - 1])
            {
                profit += prices[index] - prices[index - 1];
            }
        }

        return profit;
    }
}