// Найти сумму цифр числа

int SumDigitNumber(int number)
{
    if (number / 10 == 0) return number;
    return number % 10 + SumDigitNumber(number / 10);
}

Console.WriteLine(SumDigitNumber(234));