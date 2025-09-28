namespace LeetCode_Practice.Array;

public class MoveZeroes
{
    // public void MoveZeroeSol(int[] nums)
    // {
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             if (nums[i] == 0)
    //             {
    //                 var temp = nums[i];
    //                 nums[i] = nums[j];
    //                 nums[j] = temp;
    //             }
    //         }
    //     }
    //     
    //     Console.WriteLine(string.Join(",", nums));
    // }
    
    public void MoveZeroeSol(int[] nums)
    {
        var pointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[pointer];
                nums[pointer] = nums[i];
                nums[i] = temp;
                pointer++;
            }
        }
        
        Console.WriteLine(string.Join(",", nums));
    }
}