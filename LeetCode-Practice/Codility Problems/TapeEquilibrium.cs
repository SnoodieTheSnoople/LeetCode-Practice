namespace LeetCode_Practice.Codility_Problems;

public class TapeEquilibrium
{
    public int Solution(int[] A) 
    {
        var total = 0;

        foreach(var num in A)
        {
            total+= num;
        }

        var leftSum = 0;
        var minDiff = 2000;

        for(int i = 0; i < A.Length - 1; i++)
        {
            leftSum += A[i];
            var rightSum = total - leftSum;
            var diff = Math.Abs(leftSum - rightSum);

            if (minDiff > diff) minDiff = diff;
        }

        return minDiff;
    }
}