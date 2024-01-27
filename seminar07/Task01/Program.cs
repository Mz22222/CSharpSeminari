/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
Пример: 
N = 5  =>  1 2 3 4 5 
*/


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0)
    {
        return;
    }

    NaturalNumbers(num - 1); // она уменьшается здесь 
    Console.Write($"{num} ");
}

