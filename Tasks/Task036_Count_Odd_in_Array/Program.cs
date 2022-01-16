// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
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

(int, int) CountOddArray(int[] array)
{
    int odd = 0;
    int even = 0;

    foreach (int nextArrayNumber in array)
    {
        if (nextArrayNumber % 2 == 0) even++;
        else odd++;
    }
    return (odd, even);
}

int[] array = new int[6];
FillArray(array, 100, 999);
PrintArray(array);
(int countOdd, int countEven ) = CountOddArray(array);
System.Console.WriteLine($"Количество нечетных чисел равно {countOdd}, а количество четных равно {countEven}");
