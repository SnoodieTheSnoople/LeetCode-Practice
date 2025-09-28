namespace LeetCode_Practice.Meta;

public class ContainsDuplicateII
{
    public bool ContainsDuplicate(int[] nums, int k)
    {
        var j = 0;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
                Console.WriteLine($"Value = {dict[nums[i]]} | Key = {dict.Keys.ToList()[i]}");
            }
            else
            {
                if (Math.Abs(i - dict[nums[i]]) <= k) return true;
                
                // If not less or equal to K. Replace value of the given key to the new index.
                
                // Console.WriteLine($"Dict[i] = {dict[nums[i]]} | nums[i] = {nums[i]}");
                dict[nums[i]] = i;
            }
        }

        return false;
    }
}