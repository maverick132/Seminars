// Показать двумерный массив размером m×n заполненный целыми числами

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
            if (j == array.GetLength(1) - 1) Console.Write($"{array[i,j]}.");
            else Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = new int[4,3];
FillArray(array);
PrintArray(array);


