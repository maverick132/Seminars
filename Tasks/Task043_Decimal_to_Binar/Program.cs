// Написать программу преобразования десятичного числа в двоичное
string DecimalToBinary(int number)
{
    int result = 0;
    string numberBinary = String.Empty;

    while (number > 0)
    {
        result = number % 2;
        number /= 2;
        numberBinary += result.ToString();
    }
    return numberBinary;
}

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine()?? String.Empty) ;
Console.WriteLine($"Число {number} в двоичном представлении это {DecimalToBinary(number)}");


