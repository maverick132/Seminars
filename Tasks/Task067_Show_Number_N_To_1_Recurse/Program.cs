// // Показать натуральные числа от N до 1, N задано

void ShowNumberToN(int number)
{
    if (number == 1) Console.WriteLine(number);
    else
    {
        Console.WriteLine(number);
        ShowNumberToN(number - 1);
    }
}

int number = 10;
ShowNumberToN(number);