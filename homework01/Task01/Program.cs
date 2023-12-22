/*
Большее из двух чисел:

Внутри класса Answer напишите метод CompareNumbers, 
который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
*/


using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        /*
        Console.Write("firstNumber: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("secondNumber: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        */

       
        if (firstNumber == secondNumber)
        {
            Console.Write($"Введенные числа равны `{firstNumber}` ");
        }

        else if (firstNumber > secondNumber)
        {
            Console.Write($"Первое число `{firstNumber}` больше чем `{secondNumber}`");
        }
        else        
        {
            Console.Write($"Первое число `{firstNumber}` меньше чем `{secondNumber}`");
        }
    }

    
    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 16;
            secondNumber = 6 ;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}

