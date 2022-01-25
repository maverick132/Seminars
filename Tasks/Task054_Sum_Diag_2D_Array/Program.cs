// В матрице чисел найти сумму элементов главной диагонали

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

int SumMainDiagArray(int[,] array)
{
    int sum = 0;
    int lenght = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0); 
    for (int i = 0; i < lenght; i++)
    {
        sum += array[i, i];
    }
    return sum;
}


int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);
int sum = SumMainDiagArray(array);
Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");

