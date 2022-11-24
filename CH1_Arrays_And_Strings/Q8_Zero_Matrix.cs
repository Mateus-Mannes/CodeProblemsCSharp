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

    // runs without extra memory
    public static void Run2(int[,] matrix, int N){
        bool rowHasZero = false;
        bool columnHasZero = false;
        for(int i = 0; i < N; i++){
            for(int j = 0; j < N; j++){
                if(i == 0 && matrix[i,j] == 0) rowHasZero = true;
                if(j == 0 && matrix[i,j] == 0) columnHasZero = true;
                if(i == 0 || j == 0) continue;
                if(matrix[i,j] == 0) {
                    matrix[0,j] = 0;
                    matrix[i, 0] = 0;
                }
            }
        }
        for(int i = 1; i < N; i++)
            if(matrix[0, i] == 0) NullColumn(matrix, i);

        for(int i = 1; i < N; i++)
            if(matrix[i, 0] == 0) NullRow(matrix, i);

        if(rowHasZero) NullRow(matrix, 0);
        if(columnHasZero) NullColumn(matrix, 0);
        if(rowHasZero || columnHasZero) matrix[0,0] = 0;
    }

    private static void NullRow(int[,] matrix, int row){
        for(int j =1; j < matrix.GetLength(1); j++){
            matrix[row, j] = 0; 
        }
    }

    private static void NullColumn(int[,] matrix, int column){
        for(int i =1; i < matrix.GetLength(0); i++){
            matrix[i, column] = 0; 
        }
    }

    

}