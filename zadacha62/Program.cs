// Задача 62. Заполните спирально массив 4 на 4.

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

Console.WriteLine("Программа должна спирально заполнять массив 4х4.");
Console.WriteLine("Но я решил, что будет интереснее, если пользователь сможет задать размерность массива.");
int arraySize = ReadNaturalInt("Введите натуральное число для определения размера массива - ");
int[,] spiralArray = new int[arraySize, arraySize];
Console.WriteLine("количество элементов массива - " + spiralArray.Length);
int row = 0;
int column = 0;
int i = 0;
int k = 1;

while (k <= spiralArray.Length)
{
    while (column < (spiralArray.GetLength(1) - i))
    {
        spiralArray[row, column] = k;
        column++;
        k++;
    }
    row++;
    column--;
    while (row < spiralArray.GetLength(0) - i)
    {
        spiralArray[row, column] = k;
        row++;
        k++;
    }
    row--;
    column--;
    while (column >= 0 + i)
    {
        spiralArray[row, column] = k;
        column--;
        k++;
    }
    row--;
    column++;
    while (row >= 1 + i)
    {
        spiralArray[row, column] = k;
        row--;
        k++;
    }
    row++;
    column++;

    i++;
}

PrintIntTable(spiralArray);
Console.WriteLine("");
