/*
Задача 3: Напишите программу, которая 
1. принимает на вход целое число из отрезка [10, 99] и 
2. показывает наибольшую цифру числа.
Примеры: 
40 => 4
96 => 9
72 => 7
*/

Console.Write("Введите число от  10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

//if (num < 0 ) num = num * -1;

if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10 ;
    int secondDigit = num % 10 ;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"{num} => {firstDigit}");
    }
    else 
    {
        Console.WriteLine($"{num} => {secondDigit}");
    }
}
else 
{
    Console.WriteLine("Неверное число");
}