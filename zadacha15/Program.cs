// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int number = 0;
while (number < 1 || number > 7)
{
    Console.Write("Введите цифру обозначающую день недели - ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Нет такого дня недели!");
    }
}

if (number > 5)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}