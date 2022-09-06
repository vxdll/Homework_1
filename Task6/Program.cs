//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());
int result = numA % 2;
if (result == 0)
{
    Console.WriteLine(numA + " четное число");
}
else
{
    Console.WriteLine(numA + " нечетное число");
}
