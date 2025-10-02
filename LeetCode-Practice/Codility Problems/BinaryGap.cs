namespace LeetCode_Practice.Codility_Problems;

public class BinaryGap
{
    public int BG(int N)
    {
        var binaryList = new List<int>();
        while (N > 0)
        {
            binaryList.Add(N % 2);
            N /= 2;
        }

        var maxCounter = 0;
        var counter = 0;

        for (int i = binaryList.Count - 1; i > 0; i--)
        {
            if (binaryList[i] == 0) counter++;
            else
            {
                maxCounter = Math.Max(maxCounter, counter);
                counter = 0;
            }
        }
        return maxCounter;
    }
}