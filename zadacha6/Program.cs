﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.Write("введен ноль");
}
else{
    if (number % 2 == 0)
    {
        Console.Write("четное");
    }
    else
    {
        Console.Write("нечетное");
    }
}


