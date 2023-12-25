/*
Напишите программу, которая будет 
1. принимать на вход два числа и 
2. выводить, является ли второе число кратным первому. 
3. Если второе число некратно первому, то программа выводит остаток от деления. 
Примеры 
14, 5 => нет, 4 
16, 8 => да 
4, 3 => нет, 1
*/

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int remind = num1%num2; // remind - остаток 

if (remind == 0 )
{   
    Console.WriteLine($"{num1}, {num2} => да ");
}
else 
{
    Console.WriteLine($"{num1}, {num2} => нет, {remind} ");
}