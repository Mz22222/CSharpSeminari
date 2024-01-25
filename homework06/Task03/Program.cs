/*
Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Пример: 
"aBcD1eF!-" => Нет
"шалаш" => да 
"55655" => да       */

Console.WriteLine("Введите произвольную строку для проверки на палиндромность: ");
string std = Console.ReadLine();

CheckPalindrome(std);

void CheckPalindrome(string std)
{
    string revs = string.Empty;

    for (int i = std.Length - 1; i >= 0; i--)
    {
        revs += std[i];
    }

    if (revs == std)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}