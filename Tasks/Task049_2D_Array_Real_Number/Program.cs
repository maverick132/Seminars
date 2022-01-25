// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArrayReal(double[,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(minNumber, maxNumber+1), 3); 
        }
    }
}

void PrintArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) Console.Write($"{array[i,j]}.");
            else Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

FillArrayReal(array);
PrintArray(array);