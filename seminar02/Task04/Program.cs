/*
Напишите программу, которая 
1. выводит третью слева цифру заданного числа или сообщает, что третьей цифры нет.
456 => 6
7812 => 1
91 => Третьей цифры нет
56435 => 4
*/


//сделаем пользовательский ввод 
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = num;

if (num < 0) num *= -1;

if (num >= 100)
{
    while (num > 999)
    {
        num /= 10; // другой вариант num= num/10;
    }

    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine($"{number} => Третьей цифры нет");
}