// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Для интереса предположил, что массив надо задавать случайными целыми числами от -1000000 до -1000000.");
Console.WriteLine();
void FillIntAray(int[] array)
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

FillIntAray(array);
PrintIntArray(array);