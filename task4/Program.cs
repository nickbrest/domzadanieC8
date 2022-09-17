// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int[,] CreatePascalTriangle(int row)
{
    int[,] matrix = new int[row, row * 2 + 1];
    matrix[0, matrix.GetLength(1) / 2] = 1;
    for (int i = 1; i < matrix.GetLength(0); i++)
        for (int j = 1; j < matrix.GetLength(1) - 1; j++)
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
    return matrix;
}

const int cellWidth = 3;

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
                Console.Write($"{matrix[i, j],cellWidth}");
            else
                Console.Write($"{" ",cellWidth}");
        }
        Console.WriteLine();
    }
}

int[,] pascalTriangle = CreatePascalTriangle(10);
PrintMatrix(pascalTriangle);