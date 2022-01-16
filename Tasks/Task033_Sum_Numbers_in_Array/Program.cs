// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива. 
// Условие не совсем коректно. Массив будт состоять из [-9, 9].

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

int SumNumbersInArray(int[] array)
{
    int sum = 0;
    foreach (int nextNumberInArray in array)
    {
        sum += nextNumberInArray;
    }
    return sum;
}

int SumNumbersInArrayPositive(int[] array)
{
    int sum = 0;
    foreach (int nextNumberInArray in array)
    {
        sum = nextNumberInArray > 0 ? sum + nextNumberInArray : sum + 0;
    }
    return sum;
}

int SumNumbersInArrayNegative(int[] array)
{
    int sum = 0;
    foreach (int nextNumberInArray in array)
    {
        sum = nextNumberInArray < 0 ? sum + nextNumberInArray : sum + 0;
    }
    return sum;
}

int[] array = new int[12];
FillArray(array, -9, 9);
PrintArray(array);
Console.WriteLine($"Сумма всех чисел в данном массиве:{SumNumbersInArray(array)}");
Console.WriteLine($"Сумма всех положительных чисел в данном массиве:{SumNumbersInArrayPositive(array)}");
Console.WriteLine($"Сумма всех негативных чисел в данном массиве:{SumNumbersInArrayNegative(array)}");

