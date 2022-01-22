// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] array, int minNumber = 0, int maxNumber = 9)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minNumber, maxNumber + 1);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int CountArrayOnSection(int[] array, int startSection = 10, int endSection = 99)
{
    int countNumber = 0;
    
    foreach (int nextArrayNumber in array)
    {
        if (nextArrayNumber >= startSection && nextArrayNumber <= endSection) countNumber++;
    }
    return (countNumber);
}

int[] array = new int[123];
FillArray(array, 1, 999);
PrintArray(array);
int numberInSetction= CountArrayOnSection(array);
System.Console.WriteLine($"Количество чисел на отрезке [10, 99] равно {numberInSetction}");

