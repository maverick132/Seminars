// Показать натуральные числа от 1 до N, N задано

void ShowNumberToN(int number)
{
    if (number == 1) Console.WriteLine(number);
    else
    {
        ShowNumberToN(number - 1);
        Console.WriteLine(number);
    }
}

int number = 10;
ShowNumberToN(number);

