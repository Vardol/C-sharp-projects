// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Введите основание степени - ");
double baseForExponentiation = Convert.ToDouble(Console.ReadLine());
int exponent = -1;
while (exponent <= 0)
{
    Console.Write("Введите показатель степени (натуральное число) - ");
    exponent = Convert.ToInt32(Console.ReadLine());
    if (exponent <= 0)
    {
        Console.WriteLine("Введено ненатуральное число!");
    }
}

//Ниже под комментариями представлено решение в соответствии с условиями задачи - через цикл.
//Поскольку преподаватель предложил решать через Math.Pow(), при котором цикл не нужен, то это решения я закоментил.
//
//double result = baseForExponentiation;
// if (exponent != 1)
// {
//     for (int i = exponent; i > 1; i--)
//     {
//         result *= baseForExponentiation;
//     }
// }

//Ниже сделал решение без цикла, но с Math.Pow()
Console.WriteLine(Math.Pow(baseForExponentiation, exponent));