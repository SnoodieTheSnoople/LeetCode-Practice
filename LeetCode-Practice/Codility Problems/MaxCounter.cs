namespace LeetCode_Practice.Codility_Problems;

public class MaxCounter
{
    public int[] solution(int N, int[] A) {
        // Implement your solution here
        var counterArr = new int[N];
        var baseCount = 0;
        var maxCount = 0;

        foreach (var val in A)
        {
            if (1 <= val && val <= N)
            {
                var index = val - 1;

                if(counterArr[index] < baseCount)
                {
                    counterArr[index] = baseCount;
                }

                counterArr[index]++;

                if (counterArr[index] > maxCount)
                {
                    maxCount = counterArr[index];
                }
            }
            else if (val == N + 1)
            {
                baseCount = maxCount;
            }
        }

        for (var i = 0; i < counterArr.Length; i++)
        {
            if (counterArr[i] < baseCount)
            {
                counterArr[i] = baseCount;
            }
        }

        return counterArr;
    }
}