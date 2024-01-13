/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний, второй и предпоследний и т.д. 
Результат запишите в новый массив.

Пример: 
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/

int[] array = new int[] {1, 3, 2, 4, 2, 3, 5};
int[] newArray = new int[array.Length/2];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i]*array[array.Length-1-i];
    Console.Write($"{newArray[i]} ");
}
if (array.Length % 2 !=0)
Console.Write($"(элемент {array[array.Length/2]} не имеет пары)");