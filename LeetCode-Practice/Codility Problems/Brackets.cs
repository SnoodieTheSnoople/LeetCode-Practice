namespace LeetCode_Practice.Codility_Problems;

public class Brackets
{
    public int Solution(string s)
    {
        var dict = new Dictionary<char, char>
        {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };
        
        var stack = new Stack<char>();


        foreach (var c in s)
        {
            if (!dict.ContainsKey(c))
                stack.Push(c);
            if (dict.ContainsKey(c))
            {
                if (stack.Peek() != dict[c] || stack.Count == 0)
                    return 0;
                stack.Pop();
            }
        }
        
        return 1;
    }
}