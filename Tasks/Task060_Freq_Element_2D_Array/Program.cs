// Составить частотный словарь элементов двумерного массива
using System.Collections;

void FillArray2D(int[,] array, int minNumber = 0, int maxNumber = 9) //Заполнение двумерного массива
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

void PrintArray2D(int[,] array) //Вывод двумерного массива
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

SortedList<char, int> FreqAnalys(string text)
{
    char[] charArray = text.ToCharArray();
    SortedList<char, int> freqSimbol = new SortedList<char, int>();
    foreach (char next in charArray)
    {
        if (freqSimbol.ContainsKey(next)) freqSimbol[next]++;
        else freqSimbol.Add(next, 1);
    }
    return freqSimbol;

}

int CountChar(SortedList<char, int> sortedList)
{
    int result = 0;
    foreach (KeyValuePair<char, int> next in sortedList)
    {
        result += next.Value;
    }
    return result;
}

int CountLetter(SortedList<char, int> sortedList)
{
    int result = 0;
    foreach (KeyValuePair<char, int> next in sortedList)
    {
        if (Char.IsLetter(next.Key)) result += next.Value;
    }
    return result;
}

int CountNumber(SortedList<char, int> sortedList)
{
    int result = 0;
    foreach (KeyValuePair<char, int> next in sortedList)
    {
        if (Char.IsNumber(next.Key)) result += next.Value;
    }
    return result;
}



// void PrintSortedList(SortedList<char, int> sortedList)
// {
//     Console.WriteLine("Ключ - Значение");
//     foreach (KeyValuePair<char, int> next in sortedList)
//     {
//         Console.WriteLine($"{next.Key} - {next.Value}");
//     }
// }

void PrintFreqAnalysResult(SortedList<char, int> sortedList)
{
    int countChar = CountChar(sortedList);
    int countLetter = CountLetter(sortedList);
    int countNumber = CountNumber(sortedList);

    Console.WriteLine("Проведен частотный анализ:");
    Console.WriteLine($"Количество символов в тексте {countChar}");
    Console.WriteLine($"Количество букв {countLetter}");
    Console.WriteLine($"Количество цифр {countNumber}");

    double percent = 1;
    foreach (KeyValuePair<char, int> next in sortedList)
    {
        percent = Math.Round(((double)next.Value * 100 / countChar), 2);
        Console.WriteLine($"Символ {next.Key} встречается {next.Value} раз. Частота {percent}%.");
    }
}

// int[,] array = new int[4, 4];
// FillArray2D(array);
// PrintArray2D(array);
string text = "_2223 11 12312 222Частотный анализ – это один из методов криптоанализа, основывающийся на предположении " +
                "о существовании нетривиального статистического распределения отдельных символов и " +
                "их последовательностей как в открытом тексте, так и шифрованном тексте, " +
                "которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования._";
PrintFreqAnalysResult(FreqAnalys(text));
