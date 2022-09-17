// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] CreateMatrix3d(int depth, int length, int width)
{
    int[,,] matrix = new int[depth, length, width];
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = count++;
    return matrix;
}

void PrintMatrix3d(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
            Console.WriteLine();
        }
}

int[,,] matrix = CreateMatrix3d(4, 4, 4);

PrintMatrix3d(matrix);