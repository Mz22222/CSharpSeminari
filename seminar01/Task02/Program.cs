/*Напишите программу, которая 
1. на вход принимает целое число N, а 
2. на выходе показывает все целые числа в промежутке от -N до N. 

Примеры 
4 => -4, -3, -2, -1, 0, 1, 2, 3, 4 
2 => -2, -1, 0, 1, 2 */

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num; 

while (count <= num )
{
    Console.Write(count + " ");
    //count = count + 1;
    count++;
}
