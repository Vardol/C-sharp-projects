// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillIntArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

int ReadNaturalInt(string message)
{
    int result = -1;
    while (result <= 0)
    {
        Console.Write(message);
        result = Convert.ToInt32(Console.ReadLine());
        if (result <= 0)
        {
            Console.WriteLine("введено ненатуральное число");
        }
    }
    return result;
}


int[] array = new int[ReadNaturalInt("Введите натуральное число для определения длины массива - ")];
FillIntArray(array, -100000, 100000);

Console.WriteLine("По вашему запросу сгенерирован следующий массив:");
PrintIntArray(array);

int unevenNumbersSumm = 0;

for (int i = 1; i < array.Length; i+=2)
{
    unevenNumbersSumm = unevenNumbersSumm + array[i];
}

Console.WriteLine("Сумма чисел на нечетных позициях - " + unevenNumbersSumm + ".");
