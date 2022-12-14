// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double b1, b2, k1, k2;
Console.Write($"Введите b1 для точки 1: ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write($"Введите k1 для точки 1: ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write($"Введите b2 для точки 2: ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write($"Введите k2 для точки 2: ");
double.TryParse(Console.ReadLine()!, out k2);

double x, y;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.Write($"Точка пересечения прямых ({x}; {y})\n");