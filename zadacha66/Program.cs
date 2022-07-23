// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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

int SummNaturalNumbersRec(int startNumber, int stopNumber)
{
    if (stopNumber < startNumber) {
        int tempValue = stopNumber;
        stopNumber = startNumber;
        startNumber = tempValue;        
    }
    if (startNumber == stopNumber) return startNumber;
    return startNumber +=SummNaturalNumbersRec(startNumber + 1, stopNumber);
}


Console.WriteLine("Программа выводит сумму натуральных чисел в указанном диапазоне натуральных чисел используя рекурсию.");
Console.WriteLine("Сумма чисел в диапазоне = " + SummNaturalNumbersRec(ReadNaturalInt("Введите первую границу диапазона - "),
                                        ReadNaturalInt("Введите вторую границу диапазона - ")));