// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число: ");
int numberFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = int.Parse(Console.ReadLine());

if (numberFirst % numberSecond == 0)
{
    Console.Write("Число " + numberFirst + " кратно числу " + numberSecond);
}

else
{
    Console.Write("Число " + numberFirst + " не кратно числу " + numberSecond +
                ". Остаток от деления: " + numberFirst % numberSecond);
}

