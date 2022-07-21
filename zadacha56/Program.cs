// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void FillIntTable(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintIntTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        int j = 0;
        while (j < array.GetLength(1))
        {
            Console.Write(array[i, j]);
            j++;
            if (j < array.GetLength(1)) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

int SummOfRowIntTable (int[,] table, int indexOfRow)
{
    int summ = table[indexOfRow,0];
    for (int i = 1; i < table.GetLength(1); i++)
    {
        summ += table[indexOfRow,i];
    }
    return summ;
}

Console.WriteLine("Програма выводит строку таблицы (двумерного массива, с наименьшей суммой элементов. Для этого, програма сначала генерирует таблицу.");
int[,] twoDimensionArray = new int[new Random().Next(7, 16), new Random().Next(3, 6)];
FillIntTable(twoDimensionArray, -99, 100);
Console.WriteLine("Сгенерирован следующий массив:");
PrintIntTable(twoDimensionArray);

int sumOfMinimalRowElements = SummOfRowIntTable(twoDimensionArray,0);
int indexOfMinimalSumRow = 0;
int summOfCurrentRowElements;

for (int i = 1; i < twoDimensionArray.GetLength(0); i++)
{
    summOfCurrentRowElements = SummOfRowIntTable(twoDimensionArray,i);
    if (sumOfMinimalRowElements > summOfCurrentRowElements)
    {
        sumOfMinimalRowElements = summOfCurrentRowElements;
        indexOfMinimalSumRow = i;
    }
}

Console.WriteLine("Строка с минимальной суммой элементов - " + (indexOfMinimalSumRow+1));