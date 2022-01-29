// Спирально заполнить двумерный массив:

void FillArray2D(int[,] array, int minNumber = 0, int maxNumber = 9) //Заполнение двумерного   массива  MxN по спирали
{
    Random rnd = new Random();
    int count = 0;

    int M = array.GetLength(0);
    int N = array.GetLength(1);
    int i = 0;
    int j = 0;

    int number = 1;

    while (number <= M * N)
    {
        array[i, j] = number;

        if (i == count && j < N - count - 1) j++;
        else if (j == N - count - 1 && i < M - count - 1) i++;
        else if (i == M - count - 1 && j > count) j--;
        else i--;

        if (i == count + 1 && j == count && count != N - count - 1) 
        {
            count++;
        }
        number++;

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

int[,] array = new int[6, 6];
FillArray2D(array);
PrintArray2D(array);