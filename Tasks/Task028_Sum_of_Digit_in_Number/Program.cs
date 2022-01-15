// Подсчитать сумму цифр в числе
int SumDigit(int number)
{
    if (number < 10) return number;
    else {
        int lastDigit = number % 10;
        number /= 10;
        return lastDigit + SumDigit(number);
    }
}


Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine() ?? String.Empty);
Console.WriteLine($"Сумма всех цифр числа {numb} равна {SumDigit(numb)}");