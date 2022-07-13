// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Для интереса предположил, что массив надо задавать случайными целыми числами от -1000000 до -1000000.");
Console.WriteLine();
void FillIntArray(int[] array) //переименовал метод в соответствии с замечанием, но на мой взгляд - это несущественно,
//т.к. название метода итак полностью раскрывало суть его работы, и ошибка была чисто орфографическая, не влияющая ни на результат, ни на читаемость кода
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000000, 1000001);
    }
}

void PrintIntArray (int[] array)
{
    Console.Write("[");
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        i++;
        if (i < array.Length)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] array = new int[8];

FillIntArray(array);
PrintIntArray(array);