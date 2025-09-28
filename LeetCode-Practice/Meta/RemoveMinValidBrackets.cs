namespace LeetCode_Practice.Meta;

public class RemoveMinValidBrackets
{
    public string MinRemoveToMakeValid(string s)
    {
        /*Example 1:
           
           Input: s = "lee(t(c)o)de)"
           Output: "lee(t(c)o)de"
           Explanation: "lee(t(co)de)" , "lee(t(c)ode)" would also be accepted.
           
           Example 2:
           
           Input: s = "a)b(c)d"
           Output: "ab(c)d"
           
           Example 3:
           
           Input: s = "))(("
           Output: ""
           Explanation: An empty string is also valid.
           
         */

        var charArray = s.ToCharArray();

        var counter = 0;
        var openIndex = 0;
        var closeIndex = 0;

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == '(')
            {
                counter++;
                openIndex = i;
            }
            if (charArray[i] == ')')
            {
                counter--;
                if (counter == 0)
                {
                    closeIndex = i;
                    charArray[openIndex] = '*';
                    charArray[closeIndex] = '*';
                }
            }
        }
        
        counter = 0;
        openIndex = 0;
        closeIndex = 0;
        
        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == '(')
            {
                counter++;
                openIndex = i;
            }
            if (charArray[i] == ')')
            {
                counter--;
                if (counter == 0)
                {
                    closeIndex = i;
                    charArray[openIndex] = '*';
                    charArray[closeIndex] = '*';
                }
            }
        }

        return String.Join("", charArray);
    }
}