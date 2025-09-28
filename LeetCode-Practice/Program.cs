using LeetCode_Practice.Array;
using LeetCode_Practice.HSBC;
using LeetCode_Practice.Meta;

namespace LeetCode_Practice;

class Program
{
    static void Main(string[] args)
    {
        Stock();
    }

    static void DupeSol()
    {
        var dupeSol = new DuplicatesSol();
        Console.WriteLine(dupeSol.RemoveDuplicates([1,1,2]));
    }

    static void Stock()
    {
        var bss = new BuySellStock();
        Console.WriteLine(bss.MaxProfit([7,1,5,3,6,4]));
        Console.WriteLine(bss.MaxProfit([1,2,3,4,5]));
        Console.WriteLine(bss.MaxProfit([7,6,4,3,1]));
    }

    static void RotateArr()
    {
        var rotate = new RotateArray();
        rotate.Rotate([1, 2, 3, 4, 5, 6, 7], 3);
        rotate.Rotate([-1, -100, 3, 99], 2);
    }

    static void ContainsDupe()
    {
        var dupe = new ContainsDuplicate();
        Console.WriteLine(dupe.ContainsDup([1, 2, 3, 1]));
        Console.WriteLine(dupe.ContainsDup([1, 2, 3, 4]));
        Console.WriteLine(dupe.ContainsDup([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
    }

    static void SingleNumber()
    {
        var single = new SingleNumber();
        Console.WriteLine(single.SingleNum([2,2,1]));
        Console.WriteLine(single.SingleNum([4,1,2,1,2]));
        Console.WriteLine(single.SingleNum([1]));
    }

    static void ArrIntersect()
    {
        var intersect = new ArrayIntersection();
        Console.WriteLine(string.Join(", " , intersect.Intersect([1, 2, 2, 1], [2,2])));
        Console.WriteLine(string.Join(", ", intersect.Intersect([4,9,5],[9,4,9,8,4])));
    }

    static void PlusOne()
    {
        var plusOne = new PlusOne();
        Console.WriteLine(string.Join(", ", plusOne.PlusOneSol([1,2,3])));
        Console.WriteLine(string.Join(", ", plusOne.PlusOneSol([4,3,2,1])));
        Console.WriteLine(string.Join(", ", plusOne.PlusOneSol([9])));
        Console.WriteLine(string.Join(", ", plusOne.PlusOneSol([9,8,7,6,5,4,3,2,1,0])));
        Console.WriteLine(string.Join(", ", plusOne.PlusOneSol([9,9])));
    }
    
    static void MoveZeroes()
    {
        var moveZeroes = new MoveZeroes();
        moveZeroes.MoveZeroeSol([0,1,0,3,12]);
        moveZeroes.MoveZeroeSol([0]);
    }

    static void TwoSum()
    {
        var twoSum = new TwoSum();
        Console.WriteLine(string.Join(",",twoSum.TwoSumSol([2,7,11,15], 9)));
        Console.WriteLine(string.Join(",",twoSum.TwoSumSol([3,2,4], 6)));
        Console.WriteLine(string.Join(",",twoSum.TwoSumSol([3,3], 6)));
        Console.WriteLine(string.Join(",",twoSum.TwoSumSol([3,2,3], 6)));
        Console.WriteLine(string.Join(",",twoSum.TwoSumSol([0,4,3,0], 0)));
    }

    static void MetaRemoveMinValueValidBrackets()
    {
        var validBrackets = new RemoveMinValidBrackets();
        Console.WriteLine(validBrackets.MinRemoveToMakeValid("lee(t(c)o)de)"));
        Console.WriteLine(validBrackets.MinRemoveToMakeValid("a)b(c)d"));
        Console.WriteLine(validBrackets.MinRemoveToMakeValid("))(("));
    }

    static void ContainsDuplicateII()
    {
        var containsDupe =  new ContainsDuplicateII();
        Console.WriteLine(containsDupe.ContainsDuplicate([1,2,3,1], 3));
        Console.WriteLine(containsDupe.ContainsDuplicate([1,0,1,1], 1));
        Console.WriteLine(containsDupe.ContainsDuplicate([1,2,3,1,2,3], 2));
    }

    static void PascalsTriangleSol()
    {
        var pts = new PascalsTriangle();
        
        var result = pts.Generate(5);
        foreach (var item in result)
        {
            Console.WriteLine(String.Join(", ", item));
        }
        
        result = pts.Generate(1);
        
        foreach (var item in result)
        {
            Console.WriteLine(String.Join(", ", item));
        }
    }
}