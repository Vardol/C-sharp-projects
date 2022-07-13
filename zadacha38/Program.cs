// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillDoubleArray(double[] array, int maxPossibleDecimalPlace)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] *= Math.Pow(10,new Random().Next(0,maxPossibleDecimalPlace + 1));
        array[i] *= Math.Pow(-1,new Random().Next(1,3));
        if (array[i] >= Math.Pow(10,maxPossibleDecimalPlace))
        //Если в строке 8 сгенерировалась ровно единица, а в строке 9 - максимальный возможный множитель,
        //то значение элемента будет иметь на один разряд больше, чем задано аргументом maxPossibleDecimalPlace.
        //Например, если пользователь задал 2 знака до запятой (значение maxPossibleDecimalPlace==2), элемент примет значение ровно 100.
        //В таком случае мы скидываем счетчик на шаг назад, чтобы перегенерировать этот элемент.
        {
            i--;
        }
    }
}

void PrintDoubleArray (double[] array)
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

double[] array = new double[ReadNaturalInt("Введите натуральное число для определения размера массива - ")];
FillDoubleArray(array, ReadNaturalInt("Введите натуральное число для определения максимального числа разрядов до запятой - "));
Console.WriteLine("Сгенерирован следующий массив:");
PrintDoubleArray(array);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
        if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine("Разница между максимальным и минимальным = " + (max - min));