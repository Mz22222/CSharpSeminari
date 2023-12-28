/*
Задача 1: 
Напишите программу, которая 
1. принимает на вход число и 
2. проверяет, кратно ли оно одновременно 7 и 23.
Пример: 
a = 50 => нет 
a = 7 => нет 
a = 322 => да  
a = 161 => да 
*/


Console.WriteLine("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num % 7 == 0 && num % 23 == 0) 
{
    Console.WriteLine($"num = {num} => да ");
}
else 
{
    Console.WriteLine($"num = {num} => нет ");
}