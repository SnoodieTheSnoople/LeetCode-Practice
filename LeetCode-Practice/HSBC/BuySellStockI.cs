namespace LeetCode_Practice.HSBC;

public class BuySellStockI
{
    public int MaxProfit(int[] prices) 
    {
        var buyPrice = prices[0];
        var profit = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            var currentPrice = prices[i];
            if (buyPrice > currentPrice)
            {
                buyPrice = currentPrice;
            }
            
            profit = Math.Max(profit, prices[i] - buyPrice);
        }


        return profit;
    }
}