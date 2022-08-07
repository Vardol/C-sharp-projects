/* **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
 */

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

void FillStringArrayFromConsole(string[] inputStringArray)
{
    Console.Write("вводите строки по очереди: [");
    for (int i = 0; i < inputStringArray.Length - 1; i++)
    {
        inputStringArray[i] = Console.ReadLine();
        Console.Write(", ");
    }
    inputStringArray[inputStringArray.Length - 1] = Console.ReadLine();
    Console.Write("]");
}

void PrintStringArray(string[] inputStringArray)
{
    Console.Write("[");
    for (int i = 0; i < inputStringArray.Length - 1; i++)
    {
        Console.Write(inputStringArray[i]);
        Console.Write(", ");
    }
    Console.Write(inputStringArray[inputStringArray.Length - 1]);
    Console.Write("]");
}

int CountStringsByLengthInArray(string[] inputArray, int givenMaxLength)
{
    int result = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= givenMaxLength) result++;
    }
    return result;
}

string[] FilterStringsArrayByMaxLength(string[] inputArray, int givenMaxLength)
{
    string[] result = new string[CountStringsByLengthInArray(inputArray, givenMaxLength)];
    int fillingCount = 0;
    for (int i = 0; i < result.Length; i++)
    {
        if (inputArray[i].Length <= givenMaxLength)
        {
            result[fillingCount] = inputArray[i];
            fillingCount++;
        }
    }
    return result;
}


Console.WriteLine("Программа формирует из введенного массива строк, новый массив из строк, длина которых меньше либо равна 3 символа.");
string[] arrayOfString = new string[ReadNaturalInt("Введите натуральное число для определения количества вводимых строк (длины массива строк).")];

Console.WriteLine("");

FillStringArrayFromConsole(arrayOfString);
PrintStringArray(FilterStringsArrayByMaxLength(arrayOfString,3));

