// Показать треугольник Паскаля

ulong[,] TrianglePascale(ulong finalRow)
{
    ulong[,] result = new ulong[finalRow + 1, finalRow * 2 + 1];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = (int)finalRow - i; j <= i + (int)finalRow; j += 2)
        {
            result[i, j] = CalculateNumberPascale(i, ((j - (int)finalRow + i) / 2));

        }
    }
    return result;
}
void PrintTrianglePascale(ulong[,] array) //Вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) Console.Write($" ");
            else Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



ulong Factorial(ulong number)
{
    if (number == 1 || number == 0) return 1;

    return number * Factorial(number - 1);
}

ulong CalculateNumberPascale(int numberRow, int numberColum) =>
Factorial(Convert.ToUInt64(numberRow)) / (Factorial(Convert.ToUInt64(numberColum)) * Factorial((Convert.ToUInt64(numberRow) - Convert.ToUInt64(numberColum))));

PrintTrianglePascale(TrianglePascale(21));


//                 00
//             10      11
//         20      21      22
//     30      31      32      33
// 40      41      42      43      44

//                 04
//             13      15
//         22      24      26
//     31      33      35      37
// 40      42      44      46      48

