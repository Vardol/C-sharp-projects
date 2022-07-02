// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Для интереса будем считать, что программа 'принимает на вход случайно сгенерированную пару точек, которые сама генерирует'");
Console.WriteLine("");

void FillIntAray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10000, 10000);
    }
}

void PrintIntArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("");
}

// double[] pointOnePos = {1,2,3};
// double[] pointTwoPos = {1,2,3};

int[] pointOnePos = new int[3];
int[] pointTwoPos = new int[3];

FillIntAray(pointOnePos);
Console.Write("Сгенерирована первая точка: ");
PrintIntArray(pointOnePos);

FillIntAray(pointTwoPos);
Console.Write("Сгенерирована вторая точка: ");
PrintIntArray(pointTwoPos);

double distance (int[] pointOnePos, int[] pointTwoPos)
{
    double result = 0;
    for (int i = 0; i < pointOnePos.Length; i++)
    {
        result = result + Math.Pow(pointOnePos[i] - pointTwoPos[i], 2);
    }
    result = Math.Sqrt(result);
    return result;
}

Console.WriteLine("Расстояние между точками = " + distance(pointOnePos, pointTwoPos));
