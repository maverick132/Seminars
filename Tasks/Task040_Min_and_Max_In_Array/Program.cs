// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillArray(int[] array, int minNumber, int maxNumber)
{
    int lenght = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(minNumber, maxNumber + 1);
    }
}

void PrintArray(int[] array)
{
    int lenght = array.Length;

    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

(int, int) MinMaxInArray(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return (min, max);
}

int[] array = new int[6];
FillArray(array, -999, 999);
PrintArray(array);
(int minNumber, int maxNumber)= MinMaxInArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным числом в данном массиве равно {maxNumber - minNumber}");