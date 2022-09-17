// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}


int[] SearchMinElement(int[,] matrix)
{
    int min = matrix[0, 0]; int[] arrayMinIndex = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                arrayMinIndex[0] = i;
                arrayMinIndex[1] = j;
            }
        }
    return arrayMinIndex;
}

int[,] DelMinRowCol(int[,] matrix, int[] array)
{
    int[,] matrixNew = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0; int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == array[0]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == array[1]) continue;
            matrixNew[k, l] = matrix[i, j];
            l++;
        }
        l = 0;
        k++;
    }
    return matrixNew;
}

int[,] matrix = CreateMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] arrayIndex = SearchMinElement(matrix);
Console.WriteLine($"Наименьший элемент - строка: {arrayIndex[0] + 1}, столбец: {arrayIndex[1] + 1}");
int[,] matrixN = DelMinRowCol(matrix, arrayIndex);
Console.WriteLine();
PrintMatrix(matrixN);