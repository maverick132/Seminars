// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= N; i++)
{
    Console.WriteLine($"Куб числа {i} это {degree(i, 3)}");
}

Double degree(int number, int deg)
{
    if (deg == 1) return number;
    return (double)number * degree(number, deg -1);
}
