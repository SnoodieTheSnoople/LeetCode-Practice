namespace LeetCode_Practice.HSBC;

public class MaxArea
{
    public int MaxAreaSolution(int[] height)
    {
        var leftPointer = 0;
        var rightPointer = height.Length - 1;
        var maxArea = 0;

        while (leftPointer < rightPointer)
        {
            // Math.Max(area, width * smallest height)
            maxArea = Math.Max(maxArea, (rightPointer - leftPointer) * Math.Min(height[leftPointer], height[rightPointer]));

            if (height[leftPointer] < height[rightPointer])
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }
        
        return maxArea;
    }
}