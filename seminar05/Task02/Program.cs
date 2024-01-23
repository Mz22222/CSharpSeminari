/*
Задайте двумерный массив.
Найдиет сумму элементов, находящийхся на главной диагонали (с индексами (0;0), (1;1) и т.д.)
Пример: 
2 3 4 3 
4 3 4 1    =>   2 + 3 + 5 = 10 
2 9 5 4 
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

int SummMainDiagonal(int[,] matrix)
{
    int result = 0;
    
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1) ; i++) // код должен идти по меньшей длине матрицы, поэтому берем и строку и столбец (чтобы цикл выбирал сам из них )
    {
        result += matrix[i, i];  // берем [i, i] потому что у нас главная диагональ и там числа в индексе одинаковые, поэтому нет смысла создавать 2 цикла
    }
    return result;
}


int[,] array2D = GetMatrixRndInd(3, 4, 1, 10); // int rows, int columns, int min, int max
PrintMatrix(array2D);
Console.WriteLine();
Console.Write("Сумма элементов, находящихся на главной диагонали: ");
Console.WriteLine(SummMainDiagonal(array2D));