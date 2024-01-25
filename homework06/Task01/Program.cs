/*
Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Пример: 
a b c   =>  "abcdef"
d e f 
*/

char[,] ch = {
    {'a', 'b', 'c',},
    {'d', 'e', 'f'}
    };

Console.WriteLine(CreateStringOfSymbol(ch));

string CreateStringOfSymbol(char[,] ch)
{
    string str = string.Empty; //пустая строка 

    for (int i = 0; i < ch.GetLength(0); i++)
    {
        for (int j = 0; j < ch.GetLength(1); j++)
        {
            str += ch[i, j];
        }
    }

    return str;
}