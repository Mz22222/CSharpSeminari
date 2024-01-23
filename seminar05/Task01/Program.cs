/*
Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Пример: 
2 3 4 3       4 3 16 3 
4 3 4 1   =>  4 3 4 1 
2 9 5 4       4 9 25 4 
*/

int[,] GetMatrixRndInd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // (0) строка 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // (1) столбец
        {
            matrix[i, j] = rnd.Next(min, max); //последнее число max не входит
        }
    }                  // в данном цикле идёт проход по строкам, если хотим, чтобы проходил по стобцам, то нужно поменять местами наши циклы
                       // т.е. сначала будет for с j идти, а потом с i
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}"); // 4 это длина строки в которую будем вмещать наш результат (для каждого элемента)
        }
        Console.WriteLine();
    }
}

void ReplaceElemEvenIdxToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }

    }
}

int[,] array2D = GetMatrixRndInd(3, 4, 1, 10); // int rows, int columns, int min, int max
Console.WriteLine("Исходная матрица: ");
PrintMatrix(array2D);
ReplaceElemEvenIdxToSquare(array2D);
Console.WriteLine();
Console.WriteLine("Переделанная матрица: ");
PrintMatrix(array2D);