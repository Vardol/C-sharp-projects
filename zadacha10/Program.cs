// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = 0;
while (number < 100)
{
    Console.Write("Введите трехзначное число - ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0)
    {
        number = -number;
    }
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Введено не трехзначное число!");
    }
}
number = number / 10;
Console.WriteLine(number % 10);
