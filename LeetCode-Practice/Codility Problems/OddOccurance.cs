namespace LeetCode_Practice.Codility_Problems;

public class OddOccurance
{
    public int solution(int[] A) {
        // Implement your solution here
        if (A.Length == 1) return A[0];

        System.Array.Sort(A);

        for (int i = 0; i < A.Length - 1; i += 2)
        {
            if (A[i] != A[i+1])
                return A[i];
        }
        return A[^1];
    }

    public int solutionB(int[] A)
    {
        var xorResult = 0;
        foreach (var item in A)
        {
            xorResult ^= item;
        }
        return xorResult;
    }
}