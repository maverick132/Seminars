// Определить, присутствует ли в заданном массиве, некоторое число 
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

bool FindNumberInArray(int[] array, int number)
{
    foreach (int nextNumberInArray in array)
    {
        if (nextNumberInArray == number) return true;
    }
    return false;
}

Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[6];
FillArray(array);
PrintArray(array);

if (FindNumberInArray(array, number)) Console.WriteLine($"В данном массиве содержится число {number}"); 
else Console.WriteLine($"В данном массиве не содержится число {number}"); 