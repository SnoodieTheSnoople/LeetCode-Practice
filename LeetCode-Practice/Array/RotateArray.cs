namespace LeetCode_Practice.Array;

public class RotateArray
{
    // public void Rotate(int[] nums, int k)
    // {
    //     for (int j = 0; j < k; j++)
    //     {
    //         // Console.WriteLine(string.Join(", ", nums));
    //         var last = nums[nums.Length - 1];
    //         //Only shift numbers right
    //         for (int i = nums.Length - 1; i > 0; i--)
    //         {
    //             nums[i] = nums[i - 1];
    //         }
    //
    //         nums[0] = last;
    //         
    //     }
    //     Console.WriteLine(string.Join(", ", nums));
    // }

    public void Rotate(int[] nums, int k)
    {
        for (int i = 0; i < k; i++)
        {
            var end = nums[nums.Length - 1];
            System.Array.Copy(nums, 0, nums, 1, nums.Length - 1);
            nums[0] = end;
        }
        Console.WriteLine(string.Join(", ", nums));
    }
}