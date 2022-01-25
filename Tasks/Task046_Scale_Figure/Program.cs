// //  Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```

Console.WriteLine("Введите координаты фигуры в виде: x1,y1 x2,y2 .... xn,yn");
string inputConsole = Console.ReadLine() ?? String.Empty;
Console.WriteLine("Введите коэффициент масштабирования k:");
int k = Convert.ToInt32(Console.ReadLine() ?? String.Empty);
var coordinateFigure = inputConsole.Split(" ")
                                   .Select(item => item.Split(","))
                                   .Select(Array => (x: int.Parse(Array[0]), y: int.Parse(Array[1])))
                                   .ToArray();


for (int i = 0; i < coordinateFigure.Length; i++)
{
    Console.WriteLine($"{coordinateFigure[i].x * k}, {coordinateFigure[i].y * k}");
}