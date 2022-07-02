// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Будем считать, что 'принимает на вход' означает 'вводится пользователем'");


bool CheckIfPallindrom(string number)
{
    for (int i = 0; i <= number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}


string FixNegativeNumberInString(string number)
{
    int checkednumber = Convert.ToInt32(number);
    string result = string.Empty;
    if (checkednumber < 0)
    {
        for (int i = 1; i < number.Length; i++)
        {
            result = result + number[i];
        }
    }
    else
    {
        result = number;
    }
    return result;
}


string number = string.Empty;
while (number.Length != 5)
{
    Console.Write("Введите пятизначное число - ");
    number = Console.ReadLine();
    number = FixNegativeNumberInString(number);
    if (number.Length != 5)
    {
        Console.WriteLine("Введено не пятизначное число!");
    }
}

if (CheckIfPallindrom(number))
{
    Console.WriteLine("Да. Число - паллиндром");
}
else
{
    Console.WriteLine("Нет. Число - не паллиндром");
}