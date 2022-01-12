// Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= N; i++)
{
    Console.WriteLine($"Квадрат числа {i} это {square(i)}");
}

Double square(int number)
{
    return (double)number *  (double)number;
}
