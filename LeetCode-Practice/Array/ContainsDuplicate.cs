namespace LeetCode_Practice.Array;

public class ContainsDuplicate
{
    // public bool ContainsDup(int[] nums)
    // {
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (i == 0)
    //         {
    //             // Console.WriteLine($"i==0: {string.Join(", ", nums[(i+1)..])}");
    //             int[] copy = nums[(i + 1)..];
    //             if (copy.Contains(nums[i])) return true;
    //         }
    //         
    //         
    //         else if (i == nums.Length - 1)
    //         {
    //             // Console.WriteLine($"i==end: {string.Join(", ", nums[..i])}");
    //             int[] copy = nums[..i];
    //             if (copy.Contains(nums[i])) return true;
    //         }
    //
    //         else
    //         {
    //             // Console.WriteLine($"i=={i} | Pt1:[ {string.Join(", ", nums[..i])} ]+  Pt2:[ {string.Join(", ", nums[(i+1)..])} ]");
    //             int[] copy = nums[..i];
    //             int[] copy2 = nums[(i + 1)..];
    //             if (copy.Contains(nums[i])) return true;
    //             if (copy2.Contains(nums[i])) return true;
    //         }
    //     }
    //     return false;
    // }

    public bool ContainsDup(int[] nums)
    {
        var hash = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hash.Contains(nums[i]))
                hash.Add(nums[i]);
            else
                return true;
        }

        return false;
    }
}