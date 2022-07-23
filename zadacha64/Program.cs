// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

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

void PrintNaturalNumbersRec(int startNumber, int stopNumber)
{
    if (stopNumber < startNumber) {
        int tempValue = stopNumber;
        stopNumber = startNumber;
        startNumber = tempValue;        
    }
    Console.Write("{0} ", startNumber);
    if (startNumber == stopNumber) return;
    PrintNaturalNumbersRec(startNumber + 1, stopNumber);
}


Console.WriteLine("Программа выводит все натуральные числа в указанном диапазоне натуральных чисел используя рекурсию.");
PrintNaturalNumbersRec(ReadNaturalInt("Введите первую границу диапазона - "),
                        ReadNaturalInt("Введите вторую границу диапазона - "));