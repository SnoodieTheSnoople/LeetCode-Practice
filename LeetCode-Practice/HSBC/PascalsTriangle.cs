namespace LeetCode_Practice.HSBC;

public class PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows) {
        var triangle = new List<IList<int>>();

        var firstRow = new List<int>();
        firstRow.Add(1);
        triangle.Add(firstRow);

        for (int row = 1; row < numRows; row++)
        {
            var currentRow = new List<int>();
            var previousRow = triangle[triangle.Count - 1];
            
            currentRow.Add(1);

            // Will calculate numbers in between. 
            for (int col = 1; col < row; col++)
            {
                currentRow.Add(previousRow[col - 1] + previousRow[col]);
            }
            
            currentRow.Add(1);
            triangle.Add(currentRow);
        }
        
        return triangle;
    }
}