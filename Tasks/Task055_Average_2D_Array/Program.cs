// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(int[,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) Console.Write($"{array[i, j]}.");
            else Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageNumberInColumnArray(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double data = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            data += array[i, j];
        }
        sum[j] = Math.Round(data/array.GetLength(0), 3);
    }
    return sum;

}


int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);
double[] sum = AverageNumberInColumnArray(array);
foreach (double next in sum)
{
Console.WriteLine($"Столбец {next} ");
}
