// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите первое число - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write(number1);
    Console.Write(" больше чем ");
    Console.Write(number2);
}
else
{
    Console.Write(number2);
    Console.Write(" больше чем ");
    Console.Write(number1);
}

