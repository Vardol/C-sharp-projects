// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void FillInt3DTableUniqueValues(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
                if (CheckIfDuplicated(array, i, j, k)) k--;
            }
        }
    }
}

bool CheckIfDuplicated (int[,,] array, int rowIndexOfSearchedValue, int columnIndexOfSearchedValue, int deepnessIndexOfSearchedValue)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == array[rowIndexOfSearchedValue,columnIndexOfSearchedValue,deepnessIndexOfSearchedValue] 
                && i != rowIndexOfSearchedValue
                && j != columnIndexOfSearchedValue
                && k != deepnessIndexOfSearchedValue) return true;
            }
        }
    }
    return result;
}

void PrintInt3DTable(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0}({1},{2},{3}); ", array[i,j,k],i,j,k);
            }
            Console.WriteLine("");
        }
    }
}


Console.WriteLine("Програма формирует трёхмерный массив из неповторяющихся двузначных чисел, а затем выводит его построчно, с указанием индексов элементов.");
int[,,] array3D = new int[new Random().Next(2, 6), new Random().Next(2, 6), new Random().Next(2, 6)];
FillInt3DTableUniqueValues(array3D,10,99);
PrintInt3DTable(array3D);