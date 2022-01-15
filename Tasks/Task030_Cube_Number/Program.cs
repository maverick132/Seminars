// Показать кубы чисел, заканчивающихся на четную цифру от 10 до N
bool CheckOdd(int number)
{
    int lastDigit = number % 10;
    if (lastDigit % 2 == 0) return false;
    else return true;
}

Double AscensionToDegree(int basis, int degree) // Однако тип Double не точен, при больших вычислениях
{
    Double result = (double)basis;

    for (int i = 1; i < Math.Abs(degree); i++)
    {
        result *= basis;
    }
    return degree >= 0 ? result : 1 / result;


}

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine() ?? String.Empty);

for (int i = 10; i <= numb; i++)
{
if (!CheckOdd(i))
{
    long result = (long)AscensionToDegree(i, 3);
    Console.WriteLine($"Последняя цифра числа {i} четная и куб данного числа равен {result}");
}
}


