//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 0;
while (count <= num)
{
    if (i % 2 == 0)
    {   
        Console.WriteLine(i);
        count = count + 1;
        i = i + 1;
    }
    else
    {
        count = count + 1;
        i = i + 1;
    }
}