// Задать массив из 8 элементов и вывести их на экран 
void FillArray(int[] array, int minNumber = 0, int maxNumber = 9)
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

int[] array = new int[8];
FillArray(array, 1, 8);
PrintArray(array);

