// В прямоугольной матрице найти строку с наименьшей суммой элементов.

void FillArray2D(int[,] array, int minNumber = 0, int maxNumber = 9) //Заполнение двумерного массива
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

void PrintArray2D(int[,] array) //Вывод двумерного массива
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

int[] SumInRow(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[i, j];
        }
    }
    return result;
}

void MinSumInRow(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min]) min = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов это строка № {min}");
}

int[,] array = new int[4, 4];
FillArray2D(array);
PrintArray2D(array);
MinSumInRow(SumInRow(array));
