/*
Задайте массив символов (типа char[]).
Создайте строку из символов этого массива.
Пример: 
['a', 'b', 'c', 'd'] => "abcd"
*/

char[] ch = { 'a', 'b', 'c', 'd' };

string str = string.Empty; //пустая строка 

for (int i = 0; i < ch.Length; i++)
{
    str += ch[i];
}
Console.WriteLine(str);