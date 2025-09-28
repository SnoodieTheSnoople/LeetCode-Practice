namespace LeetCode_Practice.Array;

public class TwoSum
{
    public int[] TwoSumSol(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var result = target - nums[i];
            Console.WriteLine($"Result: {result} =  I:{nums[i]} - T:{target} | {i}");
            if (dict.ContainsValue(result))
            {
                
                return [dict.FirstOrDefault(x => x.Value == result).Key, i];
            }
            dict.Add(i, nums[i]);
        }
     
        return [0];
    }
}