namespace LeetCode_Practice;

public class QueueFromTwoStacks
{
    public static List<int> ProcessRequestQueueOperations(List<string> operations, List<int> values)
    {
        var inStack = new Stack<int>();
        var outStack = new Stack<int>();
        
        var outputEvents = new List<int>();
        
        for (int i = 0; i < operations.Count; i++)
        {
            if (operations[i].Equals("enqueue"))
            {
                inStack.Push(values[i]);
            }
            else if (operations[i].Equals("dequeue"))
            {
                if (outStack.Count == 0)
                {
                    while(inStack.Count > 0)
                    {
                        outStack.Push(inStack.Pop());
                    }
                }
                outputEvents.Add(outStack.Pop());
                
            }
            else if (operations[i].Equals("peek"))
            {
                if (outStack.Count == 0)
                {
                    while(inStack.Count > 0)
                    {
                        outStack.Push(inStack.Pop());
                    }
                }
                outputEvents.Add(outStack.Peek());
            }
            else if (operations[i].Equals("size"))
            {
                outputEvents.Add(inStack.Count + outStack.Count);
            }
        }
        return outputEvents;
    }
}