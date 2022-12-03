using ArrayAndStrings;

int[,] m = {{1, 2, 3, 4, 5}, {1, 2, 3, 4, 5}, {1, 2, 3, 4, 5}, {0, 2, 3, 0, 5}, {1, 2, 3, 4, 5}};
ZeroMatrix.Run2(m, 5);
for(int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
               Console.Write(m[i,j].ToString() + " ");
            }
            Console.WriteLine();
        }
