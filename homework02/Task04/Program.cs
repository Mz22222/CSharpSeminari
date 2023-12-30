/*
Задача 4: Напишите программу, которая на вход 
1. принимает натуральное число N, а 
2. на выходе показывает его цифры через запятую.
Примеры: 
568 => 5, 6, 8
8 => 8
9542 => 9, 5, 4, 2
*/

using Microsoft.VisualBasic;

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.Write(num);
}

else
{
    while (num > 0)
    {
        int currentDigit = num % 10;
        num = num / 10;
        if (num > 0)
        {
            Console.Write(currentDigit + ",");
        }

        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}

//Вариант ниже выводит всё в правильном порядке. А то, что выше, в обратном порядке.

/*
 Console.Write("Введите натуральное число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 10)
        {
            Console.Write(num);
        }
        else
        {
            string digitsString = "";

            while (num > 0)
            {
                int currentDigit = num % 10;
                num = num / 10;
                digitsString = currentDigit + (digitsString == "" ? "" : ", " + digitsString);
            }

            Console.WriteLine(digitsString);
        }
*/

