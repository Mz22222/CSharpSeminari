/*
Считать строку с консоли, состояющую из латинских букв в нижнем регистре.
Выяснить, сколько среди введённых букв гласных.

Пример:
"hello" => 2
"world" => 1
*/

//using System.Runtime.Intrinsics.Arm;



int CountVowels(string str)
{
    string stringVowels = "aeiouy";
    int count = 0;
    str = str.ToLower();

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < stringVowels.Length; j++)
        {
            if (str[i] == stringVowels[j])
            {
                count++;
            }

        }
    }

    return count;
}

Console.WriteLine("Введите строку из латинских букв: ");
string str = Console.ReadLine();

int count = CountVowels(str);
Console.WriteLine(count);