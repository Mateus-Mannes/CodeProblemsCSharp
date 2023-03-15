public static class Sorted_Merge {
    public static void Merge(int[] A, int[] B){
        int endAIndex = 0;
        while(A[endAIndex] != 0){
            endAIndex++;
        }

        int AEndBufferIndex = A.Count() - 1;
        int BEndIndex = B.Count() - 1;

        while(BEndIndex >= 0){
            if(endAIndex > 0 && A[endAIndex - 1] >= B[BEndIndex]){
                A[AEndBufferIndex] = A[endAIndex - 1];
                endAIndex--;
            } else {
                A[AEndBufferIndex] = B[BEndIndex];
                BEndIndex--;
            }
            AEndBufferIndex--;
        }
    }
}