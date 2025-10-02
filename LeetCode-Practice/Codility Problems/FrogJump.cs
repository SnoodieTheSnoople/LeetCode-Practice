namespace LeetCode_Practice.Codility_Problems;

public class FrogJump
{
    public int FG(int x, int y, int d)
    {
        var distanceToCover = y - x;
        var wholeJumps = distanceToCover / d;

        var positionAfterWholeJumps = x + wholeJumps * d;

        if (positionAfterWholeJumps < y) return positionAfterWholeJumps + 1;
        
        return positionAfterWholeJumps;
    }
}