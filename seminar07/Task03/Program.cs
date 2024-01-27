/*
Считать строку с консоли, содержащую латинские буквы. 
Вывести на экран согласные буквы этой строки.

Пример: 
"hello" => h l l
"world" => w r l d
"Hello world" =>  H l l w r l d
*/



void PrintConsonants(int index, string AllSymbol)
{
    // A,a,E,e,I,i,O,o,U,u,Y,y
    //int AllSymbol = AllSymbol.ToLower();
    if (index > AllSymbol.Length - 1)
    {
        return;
    }
    char t = char.ToLower(AllSymbol[index]);
    if (t != 'e' && t != 'a' && t != 'o' && t != 'i' && t != 'u' && t != 'y')
    {
        Console.Write($"{AllSymbol[index]} ");
    }
    PrintConsonants(index + 1, AllSymbol);
}


Console.WriteLine("Введите строку, содержащую латинские буквы: ");
string StringAllSymbol = Console.ReadLine();
PrintConsonants(0, StringAllSymbol);

