/*
Заполните массив на N (вводится с консоли, не более 8 )
случайных чисел от 0 до 9.

Сформируйте целое число, которое будет состоять из цифр из массива. 
Старший разряд числа находится на 0-м индексе, младший на последнемю
Пример: 
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CalcNumber(int[] array)
{
    int number = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        number = number * 10 + array[i];
    }
    return number;
}


Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = GetArrayRndInt(n, 10);
PrintArray(array);
int number = CalcNumber(array);
Console.WriteLine($"=> {number}");
