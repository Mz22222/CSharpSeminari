/*
Вывести четные числа:

Внутри класса Answer напишите метод PrintEvenNumbers, 
которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), 
разделеные знаком табуляции.
*/

using System;

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже
        int count = 1;

        while (count <= number)
        {
            if (count % 2 == 0)
            {
                //Console.Write(count + "\t");
                Console.Write(count + "\t");
            }
            count = count + 1;
        }
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}