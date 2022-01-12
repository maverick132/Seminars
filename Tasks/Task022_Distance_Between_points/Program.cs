// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("В какой системе необходимо найти расстояние 2D или 3D?");
string SysteemCoordinate = ProcessingString(Console.ReadLine());
// Console.WriteLine($"{SysteemCoordinate}");
int x1 = 0, x2 = 0, y1 = 0, y2 = 0, z1 = 0, z2 = 0;

try
{
    if (SysteemCoordinate.Equals("2D"))
    {
        Console.WriteLine("Вы выбрали систему 2D");
        Console.WriteLine("Введите координаты первой точки по х:");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты первой точки по y:");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки по х:");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки по y:");
        y2 = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        if (SysteemCoordinate.Equals("3D"))
        {
            Console.WriteLine("Вы выбрали систему 3D");
            Console.WriteLine("Введите координаты первой точки по х:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты первой точки по y:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты первой точки по z:");
            z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки по х:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки по y:");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки по z:");
            z2 = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Некорректный ввод");
}

int distance = 0;
if (SysteemCoordinate.Equals("2D"))
{
    distance  = (int)Math.Sqrt((x2 -x1) * (x2 - x1 ) + (y2 - y1) * (y2 - y1));
}
else {
    distance  = (int)Math.Sqrt((x2 -x1) * (x2 - x1 ) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 -z1));
}
Console.WriteLine($"Расстояние между данными точками {distance}");

string ProcessingString(string data)
{
    data = data.ToUpper();
    data = data.Replace("Д", "D");
    return data;
}
