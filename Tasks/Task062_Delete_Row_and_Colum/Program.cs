// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


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

(int, int) FindMinNumberArray(int[,] array)
{
    int indexMinNumberRow = 0;
    int indexMinNumberColum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[indexMinNumberRow, indexMinNumberColum])
            {
                indexMinNumberRow = i;
                indexMinNumberColum = j;
            }
        }
    }
    return (indexMinNumberRow, indexMinNumberColum);
}

int[,] DeleteRowAndColumArray(int[,] array)
{
    (int indexMinNumberRow, int indexMinNumberColum) = FindMinNumberArray(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (i < indexMinNumberRow && j < indexMinNumberColum) result[i, j] = array[i, j];
            else if (i < indexMinNumberRow) result[i, j] = array[i, j + 1];
            else if (j < indexMinNumberColum) result[i, j] = array[i + 1, j];
            else result[i, j] = array[i + 1, j + 1];
        }
    }
    return result;
}

int[,] array = new int[4, 4];


FillArray2D(array);
PrintArray2D(array);
(int i, int j) = FindMinNumberArray(array);
int[,] arrayAfterFelete = DeleteRowAndColumArray(array);
Console.WriteLine($"Строка с минимальным элементом №{i} столбец №{j}");
PrintArray2D(arrayAfterFelete);



