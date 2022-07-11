// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Введите число - ");
double numberA = Convert.ToDouble(Console.ReadLine());
int numberB = -1;
while (numberB <= 0)
{
    Console.Write("Введите натуральное число - ");
    numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB <= 0)
    {
        Console.WriteLine("введено ненатуральное число");
    }
}

double result = numberA;

if (numberB != 1)
{
    for (int i = numberB; i > 1; i--)
    {
        result = result * numberA;
    }
}

Console.WriteLine(result);