// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Поскольку в задаче отсутствуют некоторые уточнения, будем считать, что раз условиями задачи число на входе обозначено N, то оно предполагает введение натурального числа");


int number = -1;
while (number <= 0)
{
    Console.Write("Введите натуральное число - ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0)
    {
        Console.WriteLine("введено ненатуральное число");
    }
}

int current = 2;

while (current <= number)
{
    Console.Write(current);
    current = current + 2;
    if (current <= number)
    {
        Console.Write(", ");
    }
}

if (number == 1)
{
    Console.Write("введена единица");
}
