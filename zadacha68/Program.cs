// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadPositiveInt(string promtingMessageForUser)
{
    int result = -1;
    while (result < 0)
    {
        Console.Write(promtingMessageForUser);
        result = Convert.ToInt32(Console.ReadLine());
        if (result <= 0)
        {
            Console.WriteLine("введено отрицательное число");
        }
    }
    return result;
}

int AkkermanFunction(int naturalNumber1, int naturalNumber2)
{
    if (naturalNumber1 < 0 || naturalNumber2 < 0)
    {
        Console.WriteLine("Введен отрицательный аргумент. Будет возвращен 0");
        return 0;
    }
    if (naturalNumber1 > 0 && naturalNumber2 == 0) return AkkermanFunction(naturalNumber1 - 1, 1);
    if (naturalNumber1 > 0 && naturalNumber2 > 0) return AkkermanFunction(naturalNumber1 - 1, AkkermanFunction(naturalNumber1, naturalNumber2 - 1));
    return (naturalNumber2 + 1);
}


Console.WriteLine("Программа определяет число Аккермана для 2 неотрицательных натуральных чисел");
Console.WriteLine("Число Аккермана = " + AkkermanFunction(ReadPositiveInt("Введите первое положительное целое число - "),
                                        ReadPositiveInt("Введите второе положительное целое число - ")));
