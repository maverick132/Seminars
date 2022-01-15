// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

int[] MultNumber(int[] array)
{
    int lenght = array.Length;
    int newArraySize = lenght % 2 == 0 ? lenght / 2 : lenght / 2 + 1;
    int[] temp = new int[newArraySize];
    for (int i = 0; i < newArraySize ; i++) {
        temp[i] = array[i] * array[lenght - 1 - i];  
    }
    return temp;
}

int[] array = new int[10]; 
int[] array1 = new int[11];

FillArray(array, 1, 10);
FillArray(array1, 1, 10);

PrintArray(array);
PrintArray(array1);

PrintArray(MultNumber(array));
PrintArray(MultNumber(array1));

