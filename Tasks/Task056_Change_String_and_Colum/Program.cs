// Написать программу, которая обменивает элементы первой строки и последней строки

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

void ChangeStringToColums(int[,] array, int FirstString, int SecondString)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int data = array[FirstString, i];
        array[FirstString, i] = array[SecondString, i];
        array[SecondString, i] = data;
    }


}


int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);
ChangeStringToColums(array, 0, array.GetLength(0) - 1);
PrintArray(array);

