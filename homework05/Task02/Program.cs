/*
Поменяйте местами первую и последнюю строку массива.
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

Выводится:
9   10  11  12
5   6   7   8
1   2   3   4
*/

using System;

class UserInputToCompileForTest
{
    public static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] SwapFirstLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        if (rowCount >= 2)
        {
            // Создаем временный массив для хранения первой строки
            int[] tempRow = new int[colCount];
            for (int j = 0; j < colCount; j++)
            {
                tempRow[j] = array[0, j];
            }

            // Заменяем первую строку последней строкой
            for (int j = 0; j < colCount; j++)
            {
                array[0, j] = array[rowCount - 1, j];
            }

            // Восстанавливаем последнюю строку из временного массива
            for (int j = 0; j < colCount; j++)
            {
                array[rowCount - 1, j] = tempRow[j];
            }
        }

        return array;
    }

    
// Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
       //Напишите свое решение здесь
       int colCount = array.GetLength(1);

        if (i >= 0 && i < array.GetLength(0))
        {
            for (int j = 0; j < colCount / 2; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[i, colCount - 1 - j];
                array[i, colCount - 1 - j] = temp;
            }
        }
     
    }

    public static void PrintResult(int[,] numbers)
    {
        // Console.WriteLine("Исходный массив:");
        // PrintArray(numbers);

        //Console.WriteLine("\nМассив после обмена первой и последней строки:");
        int[,] result = SwapFirstLastRows(numbers);
        PrintArray(result);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Парсинг двумерного массива из аргументов
            string[] rows = args[0].Split(',');
            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка парсинга элемента {rowElements[j]} в целое число.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
        }

        UserInputToCompileForTest.PrintResult(numbers);
    }
}
