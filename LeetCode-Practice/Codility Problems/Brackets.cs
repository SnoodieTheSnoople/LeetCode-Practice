namespace LeetCode_Practice.Codility_Problems;

public class Brackets
{
    public int Solution(string S)
    {
        if (S.Length == 0) return 1; 
        if (S.Length % 2 == 1) return 0;

        var dict = new Dictionary<char, char>
        {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };

        var stack = new Stack<char>();


        foreach (var c in S)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (dict.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Peek() != dict[c])
                    return 0;
                stack.Pop();
            }
        }

        return stack.Count == 0 ? 1 : 0;
    }
}