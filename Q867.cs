namespace LeetCode;

public class Q867
{
    public static int[][] Transpose(int[][] matrix) {
        
        var m = matrix.Length; //行
        var n = matrix[0].Length; //列
        int[][] newMatrix =  new int[n][];
        for (int row = 0; row < n; row++) //行列要转换过来
        {
            newMatrix[row] =  new int[m];
            for (int col = 0;col < m; col++)
            {
                newMatrix[row][col]  = matrix[col][row] ;
            }

        }
        return newMatrix;
    }
}