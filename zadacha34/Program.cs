// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillIntArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
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

int ReadNaturalInt()
{
    int result = -1;
    while (result <= 0)
    {
        Console.Write("Введите натуральное число для определения длины массива - ");
        result = Convert.ToInt32(Console.ReadLine());
        if (result <= 0)
        {
            Console.WriteLine("введено ненатуральное число");
        }
    }
    return result;
}


int[] array = new int[ReadNaturalInt()];
FillIntArray(array, 100, 999);

Console.WriteLine("По вашему запросу сгенерирован следующий массив:");
PrintIntArray(array);

int evenNumbersCount = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenNumbersCount++;
    }
}

Console.WriteLine("Количество четных чисел в  массиве - " + evenNumbersCount + ".");