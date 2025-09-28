namespace LeetCode_Practice.Array;

public class SingleNumber
{
    // public int SingleNum(int[] nums)
    // {
    //     var dict = new Dictionary<int, int>();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (!dict.ContainsKey(nums[i]))
    //         {
    //             dict[nums[i]] = 1;
    //         }
    //         else
    //         {
    //             dict[nums[i]]++;
    //         }
    //     }
    //
    //     foreach (var item in dict)
    //     {
    //         if (item.Value == 1)
    //             return item.Key;
    //     }
    //     return 0;
    // }

    public int SingleNum(int[] nums)
    {
        int count = 0;
        foreach (var num in nums)
        {
            count ^= num;
        }
        return count;
    }
}