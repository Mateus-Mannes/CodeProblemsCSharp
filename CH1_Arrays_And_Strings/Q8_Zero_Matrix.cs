using System.Text;

namespace ArrayAndStrings;
public static class ZeroMatrix {
    ///<summary>Runs in O(NxM) time, O(NxM) extra memory</summary>
    public static void Run(int[,] matrix, int N, int M){
        var seted = new Boolean[N,M];
        for(int i = 0; i < N; i++){
            for(int j = 0; j < M; j++){
                if(matrix[i,j] == 0 && !seted[i, j]) SetZeros(matrix, seted, i, j);
            }
        }
    }
    public static void SetZeros(int[,] matrix, Boolean[,] seted, int row, int column) {
        for(int i = 0; i < matrix.GetLength(1); i++){
            matrix[row,i] = 0;
            seted[row,i] = true;
        }

        for(int i = 0; i < matrix.GetLength(0); i++){
            matrix[i, column] = 0;
            seted[i, column] = true;
        }
    }

    

}