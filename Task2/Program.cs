﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA >= numB)
{
    Console.WriteLine("max = " + numA);
    Console.WriteLine("min = " + numB);
}
else
{
    Console.WriteLine("max = " + numB);
    Console.WriteLine("min = " + numA);
}