// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

Console.WriteLine("Програма определяет произведение матриц. Для этого, програма сначала генерирует матрицы.");
int[,] matrix1 = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
FillIntTable(matrix1, -99, 99);
int[,] matrix2 = new int[matrix1.GetLength(1), new Random().Next(2, 6)];
FillIntTable(matrix2, -99, 99);



Console.WriteLine("Сгенерированы следующие матрицы:");
PrintIntTable(matrix1);
Console.WriteLine("");
PrintIntTable(matrix2);

int[,] multiplicatedMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
Console.WriteLine("Размер произведения матриц {0}х{1}", matrix1.GetLength(0), matrix2.GetLength(1));

for (int i = 0; i < multiplicatedMatrix.GetLength(0); i++)
{
    for (int j = 0; j < multiplicatedMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            multiplicatedMatrix[i,j] += matrix1[i,k]*matrix2[k,j];
        }
    }
}

Console.WriteLine("");
Console.WriteLine("Произведение матриц:");
PrintIntTable(multiplicatedMatrix);