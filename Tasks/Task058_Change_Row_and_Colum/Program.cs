// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

void ChangeRowToColum(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        
        for (int i = 0; i < array.GetLength(0) ; i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                Swap2D(array, ref array[i,j], ref array[j,i]);
            }
        }
    }
    else Console.WriteLine("Нельзя заменить строки на столбца, матрица не квадратная.");
}

void Swap2D(int[,] array, ref int firstNumber, ref int secondNumber)
{
    int data = firstNumber;
    firstNumber = secondNumber;
    secondNumber = data;
}

int[,] array = new int[4, 4];
FillArray2D(array);
PrintArray2D(array);
ChangeRowToColum(array);
PrintArray2D(array);