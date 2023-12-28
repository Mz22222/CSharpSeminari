/*

Задача 2: Напишите программу, которая 
1. принимает на вход координаты точки (X и Y), (причём X ≠ 0 и Y ≠ 0) и 
2. выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Пример: 
2, 3 => 1
-5, 3 => 2
-3, -2 => 3
4, -2 => 4
*/

Console.WriteLine("Введите координаты точки Х и У: ");
string[] coordinates = Console.ReadLine().Split(' ');

int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);

string res = " ";

if (x>0 && y>0)
{
    res = "первая четверть";
}


else if (x<0 && y>0)
{
    res = "вторая четверть";
}


else if (x<0 && y<0)
{
    res = "третяя четверть";
}


else if (x>0 && y<0)
{
    res = "четвёртая четверть";
}

else 
{
    Console.WriteLine("Неккоректно введены данные");
}

Console.WriteLine(res);