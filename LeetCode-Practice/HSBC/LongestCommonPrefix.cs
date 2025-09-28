namespace LeetCode_Practice.HSBC;

public class LongestCommonPrefix
{
    public string LCP(string[] strs) 
    {
        if(strs.Length == 0) return "";
        if(strs.Length == 1) return strs[0];
        var previousWord = strs[0];

        for(int i = 0; i < previousWord.Length; i++)
        {
            for(int wordIndex = 1; wordIndex < strs.Length; wordIndex++)
            {
                if(previousWord.Length == 0) return "";

                var word = strs[wordIndex];
                if(i == word.Length || word[i] != previousWord[i])
                {
                    return previousWord[0..i];
                }
            }
        }

        return previousWord;
    }
}