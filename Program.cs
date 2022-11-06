// Программа находит точку пересечения 2 прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2. Значения b1, k1, b2, k2 задаются пользователем 
Console.WriteLine("Input k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"2 straight lines will intersect at the point with coordinates x={x}, y={y}");