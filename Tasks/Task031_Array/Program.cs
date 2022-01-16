// Задать массив из 8 элементов и вывести их на экран 
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

int[] array = new int[8];
FillArray(array, 1, 8);
PrintArray(array);

