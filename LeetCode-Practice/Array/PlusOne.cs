namespace LeetCode_Practice.Array;

public class PlusOne
{
    public int[] PlusOneSol(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            if (digits[i] == 9)
                digits[i] = 0;
        }
        
        var newDig =  new int[digits.Length + 1];
        newDig[0] = 1;
        return newDig;
    }
}