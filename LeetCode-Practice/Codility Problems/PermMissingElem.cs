namespace LeetCode_Practice.Codility_Problems;

public class PermMissingElem
{
    public int solution(int[] A)
    {
        var N = A.Length + 1;
        var xor = 0;

        for (int i = 1; i <= N; i++)
        {
            xor ^= i;
        }

        foreach (var num in A)
        {
            xor ^= num;
        }

        return xor;
    }
}