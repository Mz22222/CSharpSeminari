/*
Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
Сформировать строку, в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами.
Пример: 
"Hello my world" => "world my Hello"
*/








Console.WriteLine ("Введите произвольную фразу: ");
string str = Console.ReadLine();

Console.Write(ReversPhrase(str));

string ReversPhrase(string str)
{
    string[] words = str.Split(); // по умолчанию стоит пробел 
    string resultStr = string.Empty;

    for (int i = words.Length - 1; i >= 0; i--) // начинаем с конца
    {
        if (i > 0)
        {
            resultStr += words[i] + " ";
        }
        else resultStr += words[i];
    }

    return resultStr;
}