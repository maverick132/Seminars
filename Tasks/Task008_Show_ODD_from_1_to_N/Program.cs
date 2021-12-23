// Показать четные числа от 1 до N

Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());

for (int i = 1; i < number + 1; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}