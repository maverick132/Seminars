// В двумерном массиве показать позиции числа, заданного пользователем 
// или указать, что такого элемента нет

void FillArray(int[,] array, int minNumber = 0, int maxNumber = 9)
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

void PrintArray(int[,] array)
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

bool ContainNumberInArray(int[,] array, int number)
{
    bool result = false;
    foreach (int next in array)
    {
        if (next == number) result = true;
    }
    return result;
}


int[,] array = new int[4, 3];
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);

if (ContainNumberInArray(array,number)) Console.WriteLine($"Число {number} присутствует в данном массиве");
else Console.WriteLine($"Число {number} не присутствует в данном массиве");