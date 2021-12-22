Console.Write("Введите первое число: ");
int numberFirst = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Int32.Parse(Console.ReadLine());

if (numberSecond * numberSecond  == numberFirst)
{
    Console.Write("Число " + numberFirst + " является квадратом числа " + numberSecond);
}

else
{
    Console.Write("Число " + numberFirst + " не является квадратом числа " + numberSecond);
}
