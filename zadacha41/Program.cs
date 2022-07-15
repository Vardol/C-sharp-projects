// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadNaturalInt(string promtingMessageForUser)
{
    int result = -1;
    while (result <= 0)
    {
        Console.Write(promtingMessageForUser);
        result = Convert.ToInt32(Console.ReadLine());
        if (result <= 0)
        {
            Console.WriteLine("введено ненатуральное число");
        }
    }
    return result;
}

int countOfNumbers = ReadNaturalInt("Сколько чисел будем вводить? ");
int countOfPositiveNumbers = 0;
double currentNumber = -1;

for (int i = 1; i <= countOfNumbers; i++)
{
    Console.Write("Введите " + i + " число - ");
    currentNumber = Convert.ToDouble(Console.ReadLine());
    if (currentNumber > 0) //будем считать, что ноль - это неположительное число
    {
        countOfPositiveNumbers++;
    }
}

Console.WriteLine("Количество положительных чисел среди введенных - " + countOfPositiveNumbers);