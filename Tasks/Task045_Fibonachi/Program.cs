// Показать числа Фибоначчи
using System.Diagnostics;

ulong Fibonachi(int number)
{
    switch (number)
    {
        case 0: return 0;
        case 1 or 2: return 1;
        default: return Fibonachi(number - 1) + Fibonachi(number - 2);
    }
}

ulong FibonachiMatrix(int number)
{
    ulong[,] matrixBase = { { 0, 1 }, { 1, 1 } };
    ulong[] fibonachiStartNumbers = { 0, 1 };
    ulong[] matrixResult = MultMatrix2x1(fibonachiStartNumbers, PowMatrix(matrixBase, number));

    return matrixResult[0];
}

ulong[,] PowMatrix(ulong[,] matrix, int degree)
{
    ulong[,] identityMatrix = { { 1, 0 }, { 0, 1 } };

    switch (degree)
    {
        case 0: return identityMatrix;
        case 1: return matrix;
        case 2: return MultMatrix2x2(matrix, matrix);
        case (> 2) when degree % 2 == 0:
            return MultMatrix2x2(PowMatrix(matrix, degree / 2),
                                 PowMatrix(matrix, degree / 2));
        case (> 2) when degree % 2 != 0:
            return MultMatrix2x2(
                        MultMatrix2x2(PowMatrix(matrix, (degree - 1) / 2),
                                      PowMatrix(matrix, (degree - 1) / 2)
                                 ), matrix);
        default: return identityMatrix;
    }

}

ulong[,] MultMatrix2x2(ulong[,] matrixFirst, ulong[,] matrixSecond)
{
    ulong[,] matrixResult = new ulong[2, 2];

    matrixResult[0, 0] = matrixFirst[0, 0] * matrixSecond[0, 0]
                       + matrixFirst[0, 1] * matrixSecond[1, 0];
    matrixResult[0, 1] = matrixFirst[0, 0] * matrixSecond[0, 1]
                       + matrixFirst[0, 1] * matrixSecond[1, 1];
    matrixResult[1, 0] = matrixFirst[1, 0] * matrixSecond[0, 0]
                       + matrixFirst[1, 1] * matrixSecond[1, 0];
    matrixResult[1, 1] = matrixFirst[1, 0] * matrixSecond[0, 1]
                       + matrixFirst[1, 1] * matrixSecond[1, 1];

    return matrixResult;
}
ulong[] MultMatrix2x1(ulong[] matrixFirst, ulong[,] matrixSecond)
{
    ulong[] matrixResult = new ulong[2];

    matrixResult[0] = matrixFirst[0] * matrixSecond[0, 0]
                    + matrixFirst[1] * matrixSecond[1, 0];
    matrixResult[1] = matrixFirst[0] * matrixSecond[0, 1]
                    + matrixFirst[1] * matrixSecond[1, 1];

    return matrixResult;
}


Console.WriteLine("Введите порядковый номер числа Фибоначи");
int number = Convert.ToInt32(Console.ReadLine() ?? String.Empty);
if (number < 0) Console.WriteLine("Введено отрицательное число.");
else
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    for (int i = 0; i < number + 1; i++)
    {
        if (i == number) Console.Write($"{Fibonachi(i)}. ");
        else Console.Write($"{Fibonachi(i)}, ");
    }
    stopwatch.Stop();
    System.Console.WriteLine();
    Console.WriteLine($"Время выполнения программы вывода чисел Фибоначчи при помощи рекурсии" +
                      $" {stopwatch.ElapsedMilliseconds}мс.");
    stopwatch.Reset();

    stopwatch.Start();
    for (int i = 0; i < number + 1; i++)
    {
        if (i == number) Console.Write($"{FibonachiMatrix(i)}. ");
        else Console.Write($"{FibonachiMatrix(i)}, ");
    }
    stopwatch.Stop();
    Console.WriteLine();
    Console.WriteLine($"Время выполнения программы вывода чисел Фибоначчи при помощи матриц" +
                      $" {stopwatch.ElapsedMilliseconds}мс.");
}