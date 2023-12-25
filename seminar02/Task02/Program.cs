/*
Напишите программу, которая 
1. принимает на вход трёхзначное число и 
2. возводит вторую цифру этого числа в степень, равную третьей цифре. 
Примеры 
487 => 8^7 = 2097152 
254 => 5^4 = 625 
617 => 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num *= -1; // это значит num = num * -1 преобразует отрицательноe в положительное
if (num >= 100 && num <= 999)
{
    int secondDigit = num % 100 / 10;
    int lastDigit = num % 10;
    int result = 1;

    for (int i = 1; i <= lastDigit; i++)
    {
        result = result * secondDigit;
    }

    Console.WriteLine(result);
}
