/*
Задайте массив из N случайных чисел (N вводится с клавиатуры)
Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
Пример: 
[1 5 11 2181 4 0 912 3] => 2
*/

int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(max);
    }
    return array;
}

int FindNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Введите размер массива ");

int n = Convert.ToInt32(Console.ReadLine());
int[] array = GetArrayRndInt(n, 100);
int count = FindNumber(array);
PrintArray(array);
Console.WriteLine($"=> {count}");