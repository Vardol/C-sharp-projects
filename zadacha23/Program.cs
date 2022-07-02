// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintQubeList(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i,3));
        if (i<= number - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine(";");
        }
    }
}


int number = 0;
while (number < 1)
{
    Console.Write("Введите число, не менее единицы - ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 1)
    {
        Console.WriteLine("Введено число меньше единицы!");
    }
}

for (int i = 1; i <= number; i++)
{
    Console.Write(i + " -> ");
    PrintQubeList(i);
}
