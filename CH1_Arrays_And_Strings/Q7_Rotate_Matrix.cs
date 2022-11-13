using System.Text;

namespace ArrayAndStrings;
public static class RotateMatrix {
    public static int[,] Run(int[,] matrix, int N, int M){
        int[,] transposed = new int[M,N];
        for(int i = 0; i < N; i++){
            for(int j = 0; j < M; j++){
                transposed[j,i] = matrix[N - 1 - i, j];
            }
        }
        return transposed;
    }

}