// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы



Random rnd = new Random();
double k1 = rnd.Next(1, 10);
double k2 = rnd.Next(1, 10);
double b1 = rnd.Next(1, 10);
double b2 = rnd.Next(1, 10);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Параметры первой точки {k1} {b1} второй точки {k2} {b2}, точка пересечения {x} {y} ");
