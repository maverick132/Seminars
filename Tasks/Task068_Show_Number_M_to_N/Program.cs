// Показать натуральные числа от M до N, N и M заданы

void ShowNumberToN(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) Console.WriteLine(firstNumber);
    else
    {
        if (firstNumber > secondNumber)
        {
            Console.WriteLine(firstNumber);
            ShowNumberToN(firstNumber - 1, secondNumber);
        }
        else
        {
             ShowNumberToN(firstNumber, secondNumber - 1);
            Console.WriteLine(secondNumber);
        }
    }
}

int number = 10;
ShowNumberToN(10, 1);
ShowNumberToN(1, 10);
