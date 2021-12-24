// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int numberFirst = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Int32.Parse(Console.ReadLine());

if (numberSecond * numberSecond == numberFirst)
{
    Console.Write("Число " + numberFirst + " является квадратом числа " + numberSecond);
}

else
{
    if (numberFirst * numberFirst == numberSecond)
    {
        Console.Write("Число " + numberSecond + " является квадратом числа " + numberFirst);
    }
    else
    {
        Console.Write("Число " + numberFirst + " не является квадратом числа " + numberSecond + ".");
        Console.Write(" Число " + numberSecond + " не является квадратом числа " + numberFirst + ".");
    }
}