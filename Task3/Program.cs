﻿// // Напишите  программу,  которая  принимает  на  вход трёхзначное целое число и на выходе показывает 
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999 || num >= -999 && num <= -100)
{
    int firstDigt = num / 100;
    int lastDigt = num % 10;
    int sum = firstDigt + lastDigt;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Некорректный ввод");
}
