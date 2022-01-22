//  Найти сумму чисел одномерного массива стоящих на нечетной позиции
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

int SumNumberInArrayOddPosition(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i+= 2)
    {

     sum+= array[i];  
           
    }
    return (sum);
}

int[] array = new int[6];
FillArray(array, 1, 999);
PrintArray(array);
int sum = SumNumberInArrayOddPosition(array);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {sum}");