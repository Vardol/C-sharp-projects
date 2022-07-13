// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

string RemoveNegativeNumberInString(string number)
{
    int checkedNumber = Convert.ToInt32(number);
    string result = string.Empty;
    if (checkedNumber < 0)
    {
        for (int i = 1; i < number.Length; i++)
        {
            result += number[i];
        }
    }
    else
    {
        result = number;
    }
    return result;
}

Console.Write("Введите число - ");
string number = Console.ReadLine();
number = RemoveNegativeNumberInString(number);
int summ = 0;
char digit = '0'; //в замечаниях было указано, что переменная не используется, но она используется на 30 строке...

for (int i = number.Length - 1; i >= 0; --i)
{
    digit = number[i];
    summ += digit - '0';
}

Console.WriteLine(summ);


