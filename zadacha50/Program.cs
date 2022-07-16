// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.


void FillDoubleTable(double[,] array, int maxPossibleDecimalPlace)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
            array[i, j] *= Math.Pow(10, new Random().Next(0, maxPossibleDecimalPlace + 1));
            array[i, j] *= Math.Pow(-1, new Random().Next(1, 3));
            if (array[i, j] >= Math.Pow(10, maxPossibleDecimalPlace)) j--;
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

Console.WriteLine("Програма выводит элемент двухмерного массива (таблицы) по его ряду и столбцу. Для этого, програма сначала генерирует таблицу");
double[,] twoDimensionArray = new double[new Random().Next(2, 6), new Random().Next(2, 6)];
FillDoubleTable(twoDimensionArray, new Random().Next(1, 6));
Console.WriteLine("Сгенерирован следующий массив:");
PrintDoubleTable(twoDimensionArray);


int searchedElementRow = ReadNaturalInt("Введите строку искомого элемента - ") - 1;
int searchedElementColumn = ReadNaturalInt("Введите столбец искомого элемента - ") - 1;

if (searchedElementRow >= twoDimensionArray.GetLength(0) || searchedElementRow < 0 ||
searchedElementColumn >= twoDimensionArray.GetLength(1) || searchedElementColumn < 0) Console.WriteLine("Нет такого элемента");
else Console.WriteLine("Искомый элемент = " + twoDimensionArray[searchedElementRow, searchedElementColumn]);