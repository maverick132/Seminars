// Найти сумму элементов от M до N, N и M заданы

int SumNumber(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber;
    else if (firstNumber > secondNumber) return firstNumber + SumNumber(firstNumber - 1, secondNumber);
        else return firstNumber + SumNumber(firstNumber + 1, secondNumber);

}

int sum = SumNumber(11, 1);

Console.WriteLine(sum);

