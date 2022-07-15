// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Программа ищет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1; y = k2 * x + b2.");
Console.Write("введите значение k1 - ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите значение b1 - ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите значение k2 - ");
double numberK2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите значение b2 - ");
double numberB2 = Convert.ToDouble(Console.ReadLine());

//преобразование уравнений для расчета х
// k1*x+b1=k2*x+b2
// k1*x-k2*x=b2-b1
// x*(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)

//преобразование уравнений для расчета y
// (y-b1)/k1=(y-b2)/k2
// (k2(y-b1)+b2*k1)/k1=y
// b2*k1-k2*b1=k1*y-k2*y
// y=(b2*k1-k2*b1)/(k1-k2)

Console.WriteLine("Точка пересечения прямых находится в координатах: " + ((numberB2-numberB1)/(numberK1-numberK2)) +
", " + ((numberB2*numberK1-numberK2*numberB1)/(numberK1-numberK2)) + ".");
