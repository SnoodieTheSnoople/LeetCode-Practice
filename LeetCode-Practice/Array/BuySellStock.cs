namespace LeetCode_Practice.Array;

public class BuySellStock
{
    // public int MaxProfit(int[] prices)
    // {
    //     var sellValues = new List<int>();
    //     var buyValues = new List<int>();
    //     for (int i = 1; i < prices.Length; i++)
    //     {
    //         if (prices[i - 1] < prices[i] && i + 1 != prices.Length)
    //             sellValues.Add(prices[i]);
    //         else if (prices[i - 1] > prices[i] && i + 1 != prices.Length)
    //             buyValues.Add(prices[i]);
    //     }
    //
    //     Console.WriteLine($"Buy Day = {string.Join(", ", sellValues)}");
    //     Console.WriteLine($"Sell Day = {string.Join(", ", buyValues)}");
    //     var profit = sellValues.Sum() - buyValues.Sum();
    //     return profit;
    // }

    public int MaxProfit(int[] prices)
    {
        Console.WriteLine(string.Join(", ", prices));
        int max = 0;
        int start = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > start)
            {
                max += prices[i] - start;
            }
            start = prices[i];
        }
        return max;
    }
}