// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит в первой четверти.");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Точка лежит в четвертой четверти.");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Точка лежит во второй четверти.");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка лежит в третьей четверти.");
}

