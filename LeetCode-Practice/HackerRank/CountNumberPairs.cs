namespace LeetCode_Practice;

public class CountNumberPairs
{
    public static int CountAffordablePairs(List<int> prices, int budget)
    {
        if (prices.Count == 1) return 0;
        var pairCount = 0;
        
        for (int i = 0; i < prices.Count; i++)
        {
            for (int j = i+1; j < prices.Count; j++)
            {
                if (prices[i] + prices[j] <= budget && j != i)
                {
                    pairCount++;
                }
            }
        }
        return pairCount;
    }
}