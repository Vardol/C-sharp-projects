// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillDoubleTable(double[,] array, int maxPossibleDecimalPlace)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
            array[i, j] *= Math.Pow(10,new Random().Next(0,maxPossibleDecimalPlace + 1));
            array[i, j] *= Math.Pow(-1,new Random().Next(1,3));
            if (array[i, j] >= Math.Pow(10,maxPossibleDecimalPlace)) j--;
            //Если в строке 8 сгенерировалась ровно единица, а в строке 9 - максимальный возможный множитель,
            //то значение элемента будет иметь на один разряд больше, чем задано аргументом maxPossibleDecimalPlace.
            //Например, если пользователь задал 2 знака до запятой (значение maxPossibleDecimalPlace==2), элемент примет значение ровно 100.
            //В таком случае мы скидываем счетчик на шаг назад, чтобы перегенерировать этот элемент.
        }
    }
}

void PrintDoubleTable(double[,] array)
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
        if (result <= 0) Console.WriteLine("введено ненатуральное число");
    }
    return result;
}

Console.WriteLine("Програма генерирует таблицу случайных чисел.");
double[,] twoDimensionArray = new double[ReadNaturalInt("Введите количество строк - "),
ReadNaturalInt("Введите количество столбцов - ")];


FillDoubleTable(twoDimensionArray, ReadNaturalInt("Введите натуральное число для определения максимального числа разрядов до запятой - "));
Console.WriteLine("Сгенерирован следующий массив:");
PrintDoubleTable(twoDimensionArray);