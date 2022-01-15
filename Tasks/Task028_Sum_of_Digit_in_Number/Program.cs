// Подсчитать сумму цифр в числе
int SumDigit(int number)
{
    if (number < 10) return number;
    else {
        int lastDigit = number % 2;
        number /= 10;
        return lastDigit + SumDigit(number);
    }
}


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine() ?? String.Empty);
Console.WriteLine($"Сумма всех цифр числа {number} равна {SumDigit(number)}");