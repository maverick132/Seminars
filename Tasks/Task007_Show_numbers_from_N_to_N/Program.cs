// Показать числа от -N до N

Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());

for (int i = -1 * number; i < number + 1; i++)
{
    Console.Write(i + " ");
}
