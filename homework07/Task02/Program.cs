/*
Задача 2: 
Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.

Пример: 
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
*/


int[] array = { 1, 2, 5, 0, 10, 34 };
ReverseArray(array, 0); 

void ReverseArray(int[] Array, int i)
{
    if (i > Array.Length - 1) 
    {
        return;
    }

    ReverseArray(Array, i + 1);
    Console.Write(Array[i] + " ");
}

