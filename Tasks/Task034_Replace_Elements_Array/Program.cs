// Написать программу замену элементов массива на противоположные. Противоположные считаем обратные по модулю.
// Так же реализуем второй вариант, когда противоположные - имеется ввиду позиционное обозначение. Т.е. первый элемент станет последним, второй предпоследним и т.д.
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

void ReplaceOnOpposite(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0 - array[i];
    }
}

void InvertArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[] array = new int[6];



FillArray(array, -100, 100);
PrintArray(array);
ReplaceOnOpposite(array);
PrintArray(array);
InvertArray(array);
PrintArray(array);


