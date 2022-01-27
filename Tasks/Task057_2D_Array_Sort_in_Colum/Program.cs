// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
using System.Linq;
using System.Diagnostics;

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

 void FillArray(int[] array, int minNumber = 0, int maxNumber = 9) //Заполнение одномерного массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minNumber, maxNumber + 1);
    }
}

void PrintArray(int[] array) //Вывод одномерного массива
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

void BubleSort2D(int[,] array) // Сортировка пузырьком 2D массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] temp = StringMatrixToArray(array, i);
        BubleSort(temp);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = temp[j];
        }

    }

}

void BubleSort(int[] array) // Сортировка пузырьком одномерного массива
{
    bool flag = false;
    while (!flag)
    {
        flag = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                Swap(array, ref array[i], ref array[i + 1]);
                flag = false;
            }
        }
    }

}

void QuickSort2D(int[,] array) // Быстрая сортировка 2D массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] temp = StringMatrixToArray(array, i);
        temp = QuickSort(temp);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = temp[j];
        }

    }

}

int[] QuickSort(int[] array) // Быстрая сортировка одномерного массива
{
    switch (array.Length)
    {
        case (< 2): return array;
        case (2):
            {
                if (array[0] < array[1]) Swap(array, ref array[0], ref array[1]);
                return array;

            }
        default:
            {
                int pivot = array[(array.Length) / 2];
                int[] elementsOver = QuickSort(array.Where(e => e > pivot)
                                                    .ToArray());
                int[] elementsUnder = QuickSort(array.Where(e => e < pivot)
                                                     .ToArray());
                int[] elementsEqual = array.Where(e => e == pivot).ToArray();
                return elementsOver.Concat(elementsEqual)
                                   .Concat(elementsUnder)
                                   .ToArray();

            }
    }

}

int[] StringMatrixToArray(int[,] array, int numberString)
{
    int[] result = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result[i] = array[numberString, i];
    }
    return result;
}

void Swap(int[] array, ref int firstNumber, ref int secondNumber)
{
    int data = firstNumber;
    firstNumber = secondNumber;
    secondNumber = data;
}



int[,] array = new int[2000, 2000];

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
FillArray2D(array);
stopwatch.Stop();
Console.WriteLine($"{stopwatch.ElapsedMilliseconds}мс.");
stopwatch.Reset();
// PrintArray2D(array);
stopwatch.Start();
BubleSort2D(array);
stopwatch.Stop();
Console.WriteLine($"Время выполнения программы сортировки пузырьком" +
                      $" {stopwatch.ElapsedMilliseconds}мс.");
stopwatch.Reset();
// PrintArray2D(array);
stopwatch.Start();
QuickSort2D(array);
stopwatch.Stop();
Console.WriteLine($"Время выполнения программы быстрой сортировки" +
                      $" {stopwatch.ElapsedMilliseconds}мс.");
stopwatch.Reset();
// PrintArray2D(array);


// void FillArray(int[] array, int minNumber = 0, int maxNumber = 9)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(minNumber, maxNumber + 1);
//     }
// }



// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}.");
//     }
//     Console.WriteLine();
// }

// int[] array = new int[8];
// FillArray(array, 1, 8);
// PrintArray(array);
// array = QuickSort(array);
// PrintArray(array);

// Random rnd = new Random();
// for (int i = 0; i < 20; i++)
// {   
//     int[] array = new int[rnd.Next(0, 31)];
//     FillArray(array, rnd.Next(-30, 1), rnd.Next(0, 31));
//     PrintArray(array);
//     array = QuickSort(array);
//     PrintArray(array);
//     TestSort(array);
// }

// void TestSort(int[] array)
// {
//     bool flag = true;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > array[i-1]) flag = false;
//     }
//     if (flag) Console.WriteLine("Массив отсортирован по возрастанию");
//     else Console.WriteLine("Ошибка");
// }