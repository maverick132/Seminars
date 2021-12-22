Console.Write("Введите первое число: ");
int numberFirst = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Int32.Parse(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.Write("Наибольшее число:  " + numberFirst + ". Наименьшее число:  " + numberSecond + ".");
}

else
{
    if (numberFirst < numberSecond)
    {
        Console.Write("Наибольшее число:  " + numberFirst + ". Наименьшее число:  " + numberSecond + ".");

    }
    else
    {
        Console.Write("Числа равны");
    }
}

