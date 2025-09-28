namespace LeetCode_Practice.Array;

public class DuplicatesSol
{
    // public int RemoveDuplicates(int[] nums)
    // {
    //     var newArr = new List<int>();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if(newArr.Contains(nums[i])) continue;
    //         newArr.Add(nums[i]);
    //     }
    //
    //     for (int i = 0; i < newArr.Count; i++)
    //     {
    //         nums[i] = newArr[i];
    //     }
    //     
    //     return newArr.Count;
    // }

    // public int RemoveDuplicates(int[] nums)
    // {
    //     var hash = nums.ToHashSet();
    //     var toArr = hash.ToArray();
    //     hash.Clear();
    //
    //     for (int i = 0; i < toArr.Length; i++)
    //     {
    //         nums[i] =  toArr[i];
    //     }
    //     return toArr.Length;
    // }
    
    public int RemoveDuplicates(int[] nums)
    {
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                Console.WriteLine($"nums[i]= {nums[i]} | nums[i-1] = {nums[i-1]}");
                Console.WriteLine($"nums[count]= {nums[count]} | nums[i] = {nums[i]}");
                nums[count]  = nums[i];
                count++;
            }
        }

        Console.WriteLine(string.Join(", ", nums));
        return count;
    }
}