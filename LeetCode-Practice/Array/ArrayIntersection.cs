namespace LeetCode_Practice.Array;

public class ArrayIntersection
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var intersectList = new List<int>();
        if(nums1.Length > nums2.Length)
            Intersect(nums2, nums1);

        var nums1List = nums1.ToList();
        foreach (var num in nums2)
        {
            if (nums1List.Contains(num))
            {
                intersectList.Add(num);
                nums1List.Remove(num);
            }
        }
        
        return intersectList.ToArray();
    }
}