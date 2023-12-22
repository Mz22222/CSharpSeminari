/* Напишите программу, которая 
1. принимает на вход трёхзначное целое число и 
2. на выходе показывает сумму первой и последней цифры этого числа. 
456 => 10 
782 => 9 
918 => 17*/




Console.WriteLine("Введите трехзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 0 )
{
    numb = numb * -1;
}

if (numb >= 100 && numb <= 999)
{
    int digitFirst = numb / 100;
    int digitLast = numb % 10;
    int sum = digitFirst + digitLast;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Неверное число ");
}
