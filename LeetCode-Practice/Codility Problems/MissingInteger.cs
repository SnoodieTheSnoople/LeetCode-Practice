namespace LeetCode_Practice.Codility_Problems;

public class MissingInteger
{
    public int MI(int[] A)
    {
        var set = A.ToHashSet();
        var counter = 1;

        while (set.Contains(counter))
        {
            counter++;
        }
        
        return counter;
    }
}