// Найти произведение двух матриц

int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(minimum, maximum);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,5:d}", matrix[i, j]);
        Console.WriteLine();
    }
}

int[,] SummMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixSumm)
{
    int summ = 0;
    for (int i = 0; i < matrixSumm.GetLength(0); i++)
        for (int j = 0; j < matrixSumm.GetLength(1); j++)
        {
            for (int k = 0; k < matrixSumm.GetLength(0); k++)
            {
                summ += matrix1[i, k] * matrix2[k, j];
            }
            matrixSumm[i, j] = summ;
            summ = 0;
        }
    return matrixSumm;
}

int[,] matrixA = CreateMatrix(5, 5, 0, 10);
int[,] matrixB = CreateMatrix(5, 5, 0, 10);
int[,] matrixC = new int[5, 5];

PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
SummMatrix(matrixA, matrixB, matrixC);
PrintMatrix(matrixC);